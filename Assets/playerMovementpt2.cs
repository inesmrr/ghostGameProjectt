using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementpt2 : MonoBehaviour
{
    public Rigidbody rb;

    public float walkSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, walkSpeed * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(walkSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-walkSpeed * Time.deltaTime, 0, 0);
        }
    }
}
