using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class DetectarFlores : MonoBehaviour
{
    [SerializeField] Button botonAccion;
    

    public SaltoJugador bloqueoSalto;

    GameObject actualFlor;
    bool cogerFlor;

    public Text cuentaFlores;
    public int cantidadFlores = 0;

    public Flowchart misionFlores;
    [SerializeField] GameObject cactus;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Flor"))
        {
            botonAccion.image.sprite = Resources.Load<Sprite>("BotonFlores");
            actualFlor = other.gameObject;
            cogerFlor = true;

            bloqueoSalto.isGrounded = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Flor"))
        {
            botonAccion.image.sprite = Resources.Load<Sprite>("BotonFlores");
            actualFlor = other.gameObject;
            cogerFlor = true;

            bloqueoSalto.isGrounded = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
     botonAccion.image.sprite = Resources.Load<Sprite>("BotonOriginal");
          
    }

    public void CogerFlores()
    {
        if (actualFlor)
        {
            SoundSystem.instance.PlayFlor();

            actualFlor.GetComponent<DestruirFlor>().DestruirFlores();
            cogerFlor = false;

            ++cantidadFlores;

            cuentaFlores.text = "Cantidad Flores: " + cantidadFlores + " /99";

            botonAccion.image.sprite = Resources.Load<Sprite>("BotonSaltar");

            misionFlores.SetBooleanVariable("CargarDialogacion", false);

            Invoke("RecuperarSalto", 0.1f);

            if (cantidadFlores == 7)
            {
                cuentaFlores.text = "Vuelve a la panadería";
                misionFlores.SetBooleanVariable("FloresCogidas", true);
                cactus.SetActive(true);
            }
        }
    }

    public void RecuperarSalto()
    {
        bloqueoSalto.isGrounded = true;
    }
}
