using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoBrasas : MonoBehaviour
{
    Transform jugador;

    UnityEngine.AI.NavMeshAgent nav;

    public Animator movBrasas;



    private void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    private void Update()
    {
       
        if (Vector3.Distance(transform.position,jugador.transform.position) <=10)
        {

            nav.SetDestination(jugador.transform.position);

            Vector3 direction = jugador.transform.position;

            transform.LookAt(direction);

            movBrasas.SetBool("Correr", true);
            movBrasas.SetBool("Parar", false);

        }
        else
        {
            movBrasas.SetBool("Parar", true);
            movBrasas.SetBool("Correr", false);

        }
        if (Vector3.Distance(transform.position, jugador.transform.position) <= 4)
        {
            movBrasas.SetBool("Correr", false);
            movBrasas.SetBool("Parar", true);
        }
        
    }

}
