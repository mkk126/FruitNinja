using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeFruits : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Kablam");
        rb = GetComponent<Rigidbody>();
        rb.AddExplosionForce(50.0f, transform.position, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
