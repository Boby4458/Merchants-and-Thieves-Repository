using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    public float speed;

    private Vector3 moveDirection;





    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            GetComponent<Animator>().SetBool("walk", false);
            return;
        }
        GetComponent<Animator>().SetBool("walk", true);
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, -Input.GetAxis("Vertical"));
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