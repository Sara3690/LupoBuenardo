using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HacerDanyo : MonoBehaviour
{
    public int cantidad = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<VidaDamageJugador>().RestarVida(cantidad);
        }
    }
}
