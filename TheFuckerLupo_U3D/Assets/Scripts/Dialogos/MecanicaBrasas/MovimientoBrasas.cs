using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimientoBrasas : MonoBehaviour
{
    Transform jugador;

    UnityEngine.AI.NavMeshAgent nav;



    private void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    private void Update()
    {
        nav.SetDestination(jugador.transform.position);

        Vector3 direction = jugador.transform.position;

        transform.LookAt(direction);

    }

}
