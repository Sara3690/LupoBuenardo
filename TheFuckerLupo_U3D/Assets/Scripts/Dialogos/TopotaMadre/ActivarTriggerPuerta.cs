using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarTriggerPuerta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<BoxCollider>();
    }

    public void activarTriggerPuertaCasaLupo()
    {
        this.GetComponent<BoxCollider>().isTrigger = true;
    }
}
