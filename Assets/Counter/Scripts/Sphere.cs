using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    
    private Rigidbody rb;
    private int xLimit = 17;
    private bool maxX = false;
    public bool ballisActive = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        ballisActive = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ballisActive)
        {
            float movHorizontal = Input.GetAxis("Horizontal");
            rb.AddForce(Vector3.forward * movHorizontal * 5);
            if (transform.position.z > (xLimit + 1))
            {
                maxX = true;
                rb.velocity = (Vector3.forward * -10);
            }
            else if (transform.position.z < -xLimit)
            {
                maxX = true;
                rb.velocity = Vector3.forward * 10;
            }
        }
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.useGravity = true;
            ballisActive = false;
        }
    }
}
