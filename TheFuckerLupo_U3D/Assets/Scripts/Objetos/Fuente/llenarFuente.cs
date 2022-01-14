using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llenarFuente : MonoBehaviour
{
    [SerializeField] Animator subirAgua;
    [SerializeField] Flowchart misionAgua;

    [SerializeField] Animator baileLupo;

    public void llenacionFuente()
    {
        if (misionAgua.GetBooleanVariable("Baile1") && misionAgua.GetBooleanVariable("Baile2") && misionAgua.GetBooleanVariable("Baile3"))
        {
            
            subirAgua.SetBool("subirAgua", true);
        }
        else
        {
            
            baileLupo.SetBool("Baile1", false);
            baileLupo.SetBool("Baile2", false);
            baileLupo.SetBool("Baile3", false);

            misionAgua.SetBooleanVariable("Repetir", true);
        }
    }
}
