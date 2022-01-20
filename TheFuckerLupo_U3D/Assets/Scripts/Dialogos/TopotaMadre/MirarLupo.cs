
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarLupo : MonoBehaviour
{
    [SerializeField] GameObject jugador;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Direccion vista madre
            Vector3 direccion = (jugador.transform.position);

            Vector3 direccionInicial = this.transform.rotation.eulerAngles;
            this.transform.LookAt(direccion); 
            Vector3 direccionLookAt = this.transform.rotation.eulerAngles; 
            this.transform.rotation = Quaternion.Euler(0 , direccionLookAt.y , 0 );

            //Direccion vista Lupo
            Vector3 direccionLupo = this.transform.position;

            Vector3 direccionInicialLupo = jugador.transform.rotation.eulerAngles;
            jugador.transform.LookAt(direccionLupo);
            Vector3 direccionLupoLookAt = jugador.transform.rotation.eulerAngles;
            jugador.transform.rotation = Quaternion.Euler(direccionInicialLupo.x, direccionLupoLookAt.y, direccionInicialLupo.z);

            
        }

    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            //Direccion vista madre
            Vector3 direccion = (jugador.transform.position);

            Vector3 direccionInicial = this.transform.rotation.eulerAngles;
            this.transform.LookAt(direccion);
            Vector3 direccionLookAt = this.transform.rotation.eulerAngles;
            this.transform.rotation = Quaternion.Euler(direccionInicial.x, direccionLookAt.y,0);

            //Direccion vista Lupo
            Vector3 direccionLupo = this.transform.position;

            Vector3 direccionInicialLupo = jugador.transform.rotation.eulerAngles;
            jugador.transform.LookAt(direccionLupo);
            Vector3 direccionLupoLookAt = jugador.transform.rotation.eulerAngles;
            jugador.transform.rotation = Quaternion.Euler(direccionInicialLupo.x, direccionLupoLookAt.y, direccionInicialLupo.z);
        }

    }

}
