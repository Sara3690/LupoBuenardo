using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoRatas : MonoBehaviour
{
    public float cronometro;
    public float cambioMovimiento;
    public float grado;
    public Quaternion angulo;
    public float rutina;
    public Animator ani;
    
   

    void Update()
    {
        cronometro = cronometro + Time.deltaTime;

        if (cronometro >= cambioMovimiento)
        {
            //rutina = Random.Range(0, 2);

            grado = Random.Range(0, 360);

            cronometro = 0;
        }
        
        angulo = Quaternion.Euler(0, grado, 0);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
        transform.Translate(Vector3.forward * 1 * Time.deltaTime);
        

    }
}
