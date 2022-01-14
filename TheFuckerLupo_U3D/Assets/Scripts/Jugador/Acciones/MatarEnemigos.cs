using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatarEnemigos : MonoBehaviour
{
    public int cantidadDanyoEnemigo = 1;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
            other.GetComponent<VidaDamageEnemigo>().RestarVida(cantidadDanyoEnemigo);
        }
    }
}
