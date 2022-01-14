using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class TestScript : MonoBehaviour
{
    //public Flowchart flowchart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {

        //flowchart.SetBooleanVariable("Trigger", true);
        //flowchart.SetStringVariable("MyName", "John");
        Debug.Log("PUTO FUNCIONA");

    }

    /*public void CallMe()
    {
        flowchart.SetBooleanVariable("Trigger", true);
        Debug.Log("Hi there");
    }*/
}
