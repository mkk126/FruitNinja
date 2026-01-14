using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject apple;
    int x;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        x = 0;
        Quaternion normal = Quaternion.identity;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(-1.4f, 1f, Random.Range(-2.0f, 2f));
       // transform.position = new
     transform.rotation = Quaternion.Euler(Random.Range(-20f, 20f), 0, 0);   
       time += Time.deltaTime;
        if (time > x)
        {
            GameObject clone = Instantiate(apple, transform.position, transform.rotation);
            x += 1;
        }
    }
}
