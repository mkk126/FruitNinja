using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AwardPoints : MonoBehaviour
{
    public static long points = 0;
    public TMP_Text myText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myText.text = "Score " + points;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Apple")
        {
            points++;
        }
    }
}
