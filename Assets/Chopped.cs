using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chopped : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject appleSplit;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool Chopped = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (Chopped)
        {
            return;
        }
        if (collision.gameObject.CompareTag("Sword")){
            Chopped = true;
            Instantiate(appleSplit, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
