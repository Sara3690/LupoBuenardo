using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickButton : MonoBehaviour
{
    ControladorJuego controladorJuego;
    void Start()
    {
        gameObject.GetComponent<Button>();
        controladorJuego = GameObject.FindGameObjectWithTag("GameController").GetComponent<ControladorJuego>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AccionBoton()
    {
        controladorJuego.accionBoton();
    }
}
