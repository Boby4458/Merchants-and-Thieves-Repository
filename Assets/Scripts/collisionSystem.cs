using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionSystem : MonoBehaviour {

    private Vector3 deltaPosition;
    public LayerMask filter;

    private void Start()
    {
        deltaPosition = transform.position;

    }
    private void Update()
    {

        RaycastHit hitInfo = new RaycastHit();

        Vector3 dir = transform.position - deltaPosition;
        Vector3 posForClosestVertex = transform.position + dir * 50;
        Vector3 curPos = GetComponent<Rigidbody>().ClosestPointOnBounds(posForClosestVertex);

        Ray ray = new Ray(deltaPosition, curPos - deltaPosition);

        if (Physics.Raycast(ray, out hitInfo, Vector3.Distance(deltaPosition, curPos), filter)) {
            Vector3 positionOffset = GetComponent<Rigidbody>().ClosestPointOnBounds(hitInfo.point) - transform.position;

            

            print("closest point on bounds " + positionOffset);
            transform.position = hitInfo.point;

            print("Collision " + hitInfo.collider.gameObject.name);
            
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);

        }

        deltaPosition = curPos;

    }
}
