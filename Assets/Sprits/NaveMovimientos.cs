using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NaveMovimientos : MonoBehaviour
{
    Rigidbody rb;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {

        float moveHorizontal = Input.GetAxis("Horizontal");

        float moveVertical = Input.GetAxis("Vertical");

        Vector3 Direccion = new Vector3(0f,moveHorizontal,0f);


        rb.velocity = Direccion * 15f;

    }
}
