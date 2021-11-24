using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
}
