using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public float speed;

    private Vector3 moveDirection;


    Vector3 forwardDir;
    Vector3 rightDir;


    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            GetComponent<Animator>().SetBool("walk", false);
            return;
        }
        GetComponent<Animator>().SetBool("walk", true);

        forwardDir = new Vector3(-Camera.main.transform.forward.x,0, -Camera.main.transform.forward.z).normalized;
        rightDir = new Vector3(-Camera.main.transform.right.x, 0, -Camera.main.transform.right.z).normalized;


        moveDirection = forwardDir * Input.GetAxis("Horizontal") + rightDir * Input.GetAxis("Vertical");

        moveDirection.Normalize();
        transform.rotation = Quaternion.FromToRotation(moveDirection, Vector3.forward * 2);

        if (transform.eulerAngles.z != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);

        }
        moveDirection = transform.TransformDirection(moveDirection);


        moveDirection *= speed;
        GetComponent<CharacterController>().SimpleMove(transform.rotation * moveDirection);


    }
}