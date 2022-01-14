using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;
using System;

public class ControladorJuego : MonoBehaviour
{
    public static ControladorJuego instance;

    [Header ("Introduccin")]
    GameObject planoIntro;
    bool activarBotones = false;

    [Header ("Variables permanentes")]
    GameObject jugador;
    GameObject botones;

    [Header("MisionPan")]
    public Flowchart misionPan;
    public Flowchart murmullos;

    [Header ("Estados")]
    private bool hablando = false;
    private bool recogiendoFlores = false;
    private bool cazandoRatas = false;
    private bool bailando = false;



    /*public Flowchart flowchartMisionPan;

    public GameObject mision;*/



    void Awake()
    {
        if (ControladorJuego.instance == null)
        {
            ControladorJuego.instance = this;
        }
        else if (ControladorJuego.instance != this)
        {
            Destroy(gameObject);
            Debug.LogWarning("ControladorJuego ha sido instanciado por segunda vez. Esto no debería pasar.");
        }

        DontDestroyOnLoad(this.gameObject);

        jugador = GameObject.FindGameObjectWithTag("Player");
        botones = GameObject.FindGameObjectWithTag("Botones");
        planoIntro = GameObject.FindGameObjectWithTag("PlanoIntro");

        botones.GetComponentInChildren<Button>();

        botones.SetActive(true);
    }

    private void Start()
    {
        botones.SetActive(false);
    }

    /* public bool GetConversacionMadre()
     {
         return flowchartMisionPan.GetBooleanVariable("YaHablaron");
     }

     int numeroFlores = 0 ;
     public void AddNumeroFlores()
     {
         numeroFlores = numeroFlores + 1;
         flowchartMisionPan.SetIntegerVariable("xxxxx", numeroFlores);
     }
     public int GetNumeroFlores()
     {
         return numeroFlores = numeroFlores + 1;
     }

     public void ActivarMisionPrincipal()
     {
         mision.SetActive(true);
     }

     //Bloque Lupo
     public void recuperarMovimiento()
     {
         jugador.GetComponent<MovimientoJugador>().enabled = true;
     }*/

    //Bloque Introducción
    public void activarBoton()
    {
        
        activarBotones = true;

        if (activarBotones == true)
        {
            botones.SetActive(true);
            planoIntro.SetActive(false);
        }
    }

   internal void accionBoton()
    {

        if (murmullos.GetBooleanVariable("LupoEntra"))
        {
            hablando = true;

            if (hablando == true)
            {
                misionPan.SetBooleanVariable("CargarDialogo", true);

                
              
            }
        }

        /*

        else if (recogiendoFlores == true)
        {

        }

        else if (cazandoRatas == true)
        {

        }

        else if (bailando == true)
        {

        }*/
    }

}
