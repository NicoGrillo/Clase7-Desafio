using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        MoveAxis();
    }
    private void MoveAxis()
    {
        float ejeHorizontal = Input.GetAxis("Horizontal");
        float ejeVertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(ejeHorizontal, 0, ejeVertical) * speed * Time.deltaTime);
    }
}
