using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetirBaile : MonoBehaviour
{
    public Flowchart baile;

    public void Baile()
    {
        if (baile.GetBooleanVariable("Baile1") && baile.GetBooleanVariable("Baile2") && baile.GetBooleanVariable("Baile3"))
        {
            baile.SetBooleanVariable("Repetir", false);
        }
        else
        {
            baile.SetBooleanVariable("Repetir", true);
        }
    }
}
