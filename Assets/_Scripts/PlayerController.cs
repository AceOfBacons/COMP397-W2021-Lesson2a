using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            //Move to the right
            rb.AddForce(Vector3.right * movementForce);
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //Move to the left 
            rb.AddForce(Vector3.left * movementForce);
        }
    }
}
