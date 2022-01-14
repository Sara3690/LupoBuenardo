using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour
{
    public static SoundSystem instance;
    public AudioSource fuenteEfectoSonido;
    public AudioSource fuenteMusica;
    public AtaqueJugador ratas;

    

    //public float tiempo;

    public AudioClip musicaFondo;
    [Header("sonidos")]
    public AudioClip sonidoSalto;
    public AudioClip sonidoGolpe;
    public AudioClip sonidoFlor;
    public AudioClip sonidoEspada;
    public AudioClip sonidoVictory;
    public AudioClip sonidoBatalla;
    public AudioClip sonidoMuerte;
    public AudioClip sonidoMuerteLupo;

    private void Awake()
    {
       if (SoundSystem.instance == null)
        {
            SoundSystem.instance = this;
        }
        else if (SoundSystem.instance = this)
        {
            Destroy(gameObject);
        }

    }
    public void PlaySalto()
    {
        fuenteEfectoSonido.clip = sonidoSalto;
        fuenteEfectoSonido.Play();
    }

    public void PlayGolpe()
    {
        fuenteEfectoSonido.clip = sonidoGolpe;
        fuenteEfectoSonido.Play();
    }

    public void PlayFlor()
    {
        fuenteEfectoSonido.clip = sonidoFlor;
        fuenteEfectoSonido.Play();
    }
    public void PlayBatalla()
    {
        fuenteMusica.clip = sonidoBatalla;
        fuenteMusica.Play();
    }

    public void PlayEspada()
    {
        fuenteEfectoSonido.clip = sonidoEspada;
        fuenteEfectoSonido.Play();
    }
    public void PlayVictory()
    { 
            fuenteMusica.clip = sonidoVictory;
            fuenteMusica.Play();
    }

    public void PlayMusicaFondo()
    {
        fuenteMusica.clip = musicaFondo;
        fuenteMusica.Play();
    }

    public void PlayMuerte()
    {
        fuenteEfectoSonido.clip = sonidoMuerte;
        fuenteEfectoSonido.Play();
    }

    public void PlayMuerteLupo()
    {
        fuenteEfectoSonido.clip = sonidoMuerteLupo;
        fuenteEfectoSonido.Play();
    }


    private void OnDestroy()
    {
        if (SoundSystem.instance == this)
        {
            SoundSystem.instance = null;
        }
    }
}
