using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.up * 8.0f, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
