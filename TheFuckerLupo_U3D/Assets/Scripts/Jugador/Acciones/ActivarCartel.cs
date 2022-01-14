using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivarCartel : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject camaraCartel;

    [SerializeField] GameObject botonMover;

    [SerializeField] Flowchart misionAgua;
    [SerializeField] Flowchart misionRatas;

    public int cambioVista;

    
    public void VerCartel()
    {
       
        if (misionAgua.GetBooleanVariable("PreCogerAgua"))
        {
           cambioVista++;
           

            if (cambioVista == 1)
            {
                mainCamera.SetActive(false);
                camaraCartel.SetActive(true);
                botonMover.SetActive(false);
            }

            if (cambioVista == 2)
            {
                mainCamera.SetActive(true);
                camaraCartel.SetActive(false);
                botonMover.SetActive(true);

                if (misionRatas.GetBooleanVariable("HarinaConseguida"))
                {
                    misionAgua.SetBooleanVariable("EmpezarBaile", true);
                }

                cambioVista = 0;
            }

        }

    }
}
