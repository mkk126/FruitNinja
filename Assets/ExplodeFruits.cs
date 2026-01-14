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
        rb.AddExplosionForce(50f, transform.position + Vector3.down * 0.25f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
