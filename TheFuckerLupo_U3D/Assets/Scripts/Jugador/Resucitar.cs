using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resucitar : MonoBehaviour
{
    public GameObject jugador;
    public GameObject botonResucitar;
    public void Resucitacion()
    {
        jugador.gameObject.SetActive(true);
        botonResucitar.SetActive(false);
    }
}
