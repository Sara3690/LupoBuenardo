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

        /*baileLupo.SetTrigger("Bailesito2");

        misionAgua.SetBooleanVariable("Baile2", true);*/

        StartCoroutine(Bailamiento2());
    }

    public void Animacion3()
    {

        /*baileLupo.SetTrigger("Bailesito3");
        misionAgua.SetBooleanVariable("Baile3", true);*/
        StartCoroutine(Bailamiento3());
    }

   
    IEnumerator Bailamiento1 ()
    {
        
        baileLupo.SetTrigger("Bailesito1");
        misionAgua.SetBooleanVariable("Baile1", true);
        baile1.SetActive(false);


        yield return new WaitForSeconds(4.2f);
        baile2.SetActive(true);

    }

    IEnumerator Bailamiento2()
    {
        
        baileLupo.SetTrigger("Bailesito2");
        misionAgua.SetBooleanVariable("Baile2", true);
        baile2.SetActive(false);

        yield return new WaitForSeconds(4.7f);

       
        baile3.SetActive(true);

    }

    IEnumerator Bailamiento3()
    {

        baileLupo.SetTrigger("Bailesito3");
        misionAgua.SetBooleanVariable("Baile3", true);
        baile3.SetActive(false);
        yield return new WaitForSeconds(4.7f);
        

    }


}
