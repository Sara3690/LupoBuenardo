using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaltoJugador : MonoBehaviour
{
    public Rigidbody rbd;

    [SerializeField] Button botonAccion;

    [SerializeField] Flowchart misionPan;
    [SerializeField] Flowchart misionFlores;
    [SerializeField] Flowchart misionRatas;
    public Flowchart murmullosPanadero;


    public float fuerzaSalto;

    public bool isGrounded;

    public Animator saltoLupo;

    public MovimientoJugador moverLupo;

    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody>();

        isGrounded = false;

    }

    public void BloqueoSalto()
    {
        if (isGrounded == true)
        {
            Jump();
            botonAccion.image.sprite = Resources.Load<Sprite>("BotonOriginal");
            misionPan.SetBooleanVariable("CargarDialogo", false);
            misionFlores.SetBooleanVariable("CargarDialogacion", false);
            misionRatas.SetBooleanVariable("CargarDialogo", false);

            saltoLupo.SetTrigger("esSalto");

            SoundSystem.instance.PlaySalto();

            saltoLupo.SetBool("noCaida", true);

          
        }
       
    }

    void arregloCaida()
    {
        saltoLupo.SetBool("noCaida", false);

    }
    public void Jump()
    {
        isGrounded = false;
        rbd.AddForce(0, fuerzaSalto, 0);
        misionFlores.SetBooleanVariable("CargarDialogacion", false);
        murmullosPanadero.SetBooleanVariable("LupoEntracion", false);
    }

    public void OnCollisionEnter(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("Suelo"))
        {
            isGrounded = true;

            botonAccion.image.sprite = Resources.Load<Sprite>("BotonSaltar");

            moverLupo.enabled = true;
        }
    }

    public void OnCollisionStay(UnityEngine.Collision other)
    {
        if (other.gameObject.CompareTag("Suelo"))
        {
            isGrounded = true;

            botonAccion.image.sprite = Resources.Load<Sprite>("BotonSaltar");

            moverLupo.enabled = true;
        }
    }

    public void OnCollisionExit(UnityEngine.Collision other)
    {
        
            isGrounded = false;

            botonAccion.image.sprite = Resources.Load<Sprite>("BotonOriginal");
        

    }
}
