using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDamageEnemigo : MonoBehaviour
{
    public int vida = 2;

    public AtaqueJugador matarRatas;

    public void RestarVida(int cantidadDanyoEnemigo)
    {
        vida -= cantidadDanyoEnemigo;

        SoundSystem.instance.PlayGolpe();

        if (vida == 0)
        {
            SoundSystem.instance.PlayMuerte();

            matarRatas.cantidadRatas--;
            this.gameObject.SetActive(false);

           
        }

       
    }
}
