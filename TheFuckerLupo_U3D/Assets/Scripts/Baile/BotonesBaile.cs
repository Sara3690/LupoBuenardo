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

        /*baileLupo.SetTrigger("Bailesito1");
        misionAgua.SetBooleanVariable("Baile1", true);*/
        StartCoroutine(Bailamiento1());

    }

    public void Animacion2()
    {
      
        baileLupo.SetTrigger("Bailesito2");

        misionAgua.SetBooleanVariable("Baile2", true);
    }

    public void Animacion3()
    {

        baileLupo.SetTrigger("Bailesito3");
        misionAgua.SetBooleanVariable("Baile3", true);
    }

    private void Start()
    {
        //StartCoroutine (Bailamiento1());
    }
    IEnumerator Bailamiento1 ()
    {
        Debug.Log("puto");
        baileLupo.SetTrigger("Bailesito1");
        misionAgua.SetBooleanVariable("Baile1", true);
        yield return new WaitForSeconds(4.2f);

        baile1.SetActive(false);
        baile2.SetActive(true);

    }

    
}
