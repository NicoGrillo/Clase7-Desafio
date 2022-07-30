using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1F;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Movement(Vector3.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Movement(Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Movement(Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Movement(Vector3.right);
        }
    }
    private void Movement(Vector3 value)
    {
        transform.Translate(value * speed * Time.deltaTime);
    }
}
