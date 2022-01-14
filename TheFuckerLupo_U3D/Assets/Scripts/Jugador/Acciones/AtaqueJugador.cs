using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtaqueJugador : MonoBehaviour
{
    
    [SerializeField] Animator ataquePala;
    bool modoAtaque;

    public Collider golpeador;

    public Animator activarCollider;

    public Button botonAccion;

    public Flowchart misionRatas;

    public Text contadorRatas;

    public GameObject contarRatas;

    public GameObject vuelveMolinero;

    public int cantidadRatas = 4;

    public SoundSystem soundSystem;

    public float activarMusica = 0 ;
   

    private void Update()
    {
        contadorRatas.text = "Ratas restantes: " + cantidadRatas;

        if (cantidadRatas == 0)
        {

            activarMusica = activarMusica + Time.deltaTime ;

            //activarMusica++;
            if (activarMusica < 0.1)
            {
                SoundSystem.instance.PlayVictory();
                //activarMusica = 1;
            }

            if (activarMusica < 4.04 && activarMusica > 4)
            {
                SoundSystem.instance.PlayMusicaFondo();
                
               
            }

            

            misionRatas.SetBooleanVariable("RatasMuertas", true);

            contarRatas.SetActive(false);
            vuelveMolinero.SetActive(true);
        }
    }
    public void AtaquePala()
    {
        
        if (modoAtaque == true)
        {
            SoundSystem.instance.PlayEspada();

            ataquePala.SetTrigger("esAtaque");

         activarCollider.SetTrigger("muele");

         misionRatas.SetBooleanVariable("CargarDialogo", false);
        }

    }

    public void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("SueloMolino"))
        {
            modoAtaque = true;
            botonAccion.image.sprite = Resources.Load<Sprite>("BotonAtaque");

            if (cantidadRatas >= 1)
            {
                //SoundSystem.instance.PlayBatalla();
                SoundSystem.instance.PlayBatalla();
            }

        }

    }

    public void OnCollisionStay(UnityEngine.Collision other)
    {

        if (other.gameObject.CompareTag("SueloMolino"))
        {
            modoAtaque = true;
            botonAccion.image.sprite = Resources.Load<Sprite>("BotonAtaque");

            

        }
    }

    public void OnCollisionExit(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("SueloMolino"))
        {
            modoAtaque = false;
           
        }
    }

}
