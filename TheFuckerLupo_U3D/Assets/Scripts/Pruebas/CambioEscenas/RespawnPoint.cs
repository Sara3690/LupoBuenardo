using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPoint : MonoBehaviour
{
    [SerializeField] public GameObject jugador;
    [SerializeField] public Transform respawnPoint;

    private void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            jugador.transform.position = respawnPoint.transform.position;
            Physics.SyncTransforms();

        }
    }
    
}
