using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Controller_script : MonoBehaviour
{
    // Start is called before the first frame update

    public SteamVR_Action_Boolean grip_action;
    public SteamVR_Action_Single squeeze_action;
    public SteamVR_Input_Sources hand;
    public GameObject cube;
    public MeshRenderer renderer;
    Color color;

    void Start()
    {
            color = renderer.material.color;
}

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(color.a = squeeze_action.GetAxis(hand));
        Debug.Log(grip_action.GetState(hand));
    }


    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log(grip_action.GetChanged(hand));
        if (collision.gameObject.name == "Cube")
        {

            color.a =  1 - squeeze_action.GetAxis(hand);
            renderer.material.color = color;
        }

    }
    private void OnTriggerStay(Collider collision)
    {
        Debug.Log("Stay Trigger");
        if (collision.gameObject.name == "Cube")
        {

            color.a = 1 -  squeeze_action.GetAxis(hand);
            renderer.material.color = color;
            if (grip_action.GetState(hand))
            {
                collision.gameObject.transform.position = this.transform.position;
                collision.gameObject.transform.rotation = this.transform.rotation;
            }
        }
    }
}
