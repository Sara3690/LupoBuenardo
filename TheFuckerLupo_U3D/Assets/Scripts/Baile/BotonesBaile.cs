using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonesBaile : MonoBehaviour
{
    [SerializeField] GameObject baile1;
    [SerializeField] GameObject baile2;
    [SerializeField] GameObject baile3;

    [SerializeField] Animator baileLupo;

    [SerializeField] Flowchart misionAgua;

    public void Animacion1()
    {
        baileLupo.SetBool("Baile1", true);

        baile1.SetActive(false);

        misionAgua.SetBooleanVariable("Baile1", true);
    }

    public void Animacion2()
    {
        baileLupo.SetBool("Baile2", true);
        baileLupo.SetBool("Baile1", false);

        baile2.SetActive(false);

        misionAgua.SetBooleanVariable("Baile2", true);
    }

    public void Animacion3()
    {
        baileLupo.SetBool("Baile3", true);
        baileLupo.SetBool("Baile1", false);
        baileLupo.SetBool("Baile2", false);

        baile3.SetActive(false);

        misionAgua.SetBooleanVariable("Baile3", true);
    }

    
}
