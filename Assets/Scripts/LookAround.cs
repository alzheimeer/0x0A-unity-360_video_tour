using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public float speed = 3;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.RotateAround(transform.position, -Vector3.up, speed * Input.GetAxis("Mouse X"));
            transform.RotateAround(transform.position, -Vector3.right, speed * Input.GetAxis("Mouse Y"));
        }
    }


}