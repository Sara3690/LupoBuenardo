using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoPosicion : MonoBehaviour
{
    public Color color = Color.blue;
    public float tamano = 1;

    public void OnDrawGizmos()
    {
        Gizmos.color = color;
        Gizmos.DrawWireSphere(this.transform.position, tamano);
    }
}
