using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDamageJugador : MonoBehaviour
{
    public int vida = 3;

    public GameObject botonResucitar;

    public Animator lupoDanyo;
    public void RestarVida(int cantidad)
    {
        vida -= cantidad;
        lupoDanyo.SetTrigger("danyo");
        SoundSystem.instance.PlayDayoLupo();

        if (vida == 0)
        {
            SoundSystem.instance.PlayMuerteLupo();

            this.gameObject.SetActive(false);
            botonResucitar.SetActive(true);

            
        }
    }

    
}
