using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public Vector3 offset;
    public Transform player;

    private void LateUpdate()
    {
        transform.position = player.position + offset;
    }
}
