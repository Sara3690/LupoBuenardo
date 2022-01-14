using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ActivarDialogo : MonoBehaviour
{
    //Activar mision pan.
    [SerializeField] Flowchart murmullos;
    [SerializeField] Flowchart misionPan;

    //Activar mision flores.
    [SerializeField] Flowchart murmullosPanadera;
    [SerializeField] Flowchart misionFlores;

    //Activar mision ratas.
    [SerializeField] Flowchart murmullosMolinero;
    [SerializeField] Flowchart misionRatas;


    public void ActivacionDialogoMisionPan()
    {
     
     //activar dialogo misionPan.
     if (murmullos.GetBooleanVariable("LupoEntra"))
        {
         misionPan.SetBooleanVariable("CargarDialogo", true);
         misionFlores.SetBooleanVariable("CargarDialogacion", false);
         misionRatas.SetBooleanVariable("CargarDialogo", false);
          
        }

     //activar dialogo MisionFlores.
     if (murmullosPanadera.GetBooleanVariable("LupoEntracion"))

        {
            misionFlores.SetBooleanVariable("CargarDialogacion", true);
            misionPan.SetBooleanVariable("CargarDialogo", false);
            misionRatas.SetBooleanVariable("CargarDialogo", false);
        }

        //activar dialogo MisionRatas.
        if (murmullosMolinero.GetBooleanVariable("LupoEntra"))

        {
            misionRatas.SetBooleanVariable("CargarDialogo", true);
            misionPan.SetBooleanVariable("CargarDialogo", false);
            misionFlores.SetBooleanVariable("CargarDialogacion", false);
        }

    }

   
}
