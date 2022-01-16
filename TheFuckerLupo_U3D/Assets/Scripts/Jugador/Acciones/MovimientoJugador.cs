using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoJugador : MonoBehaviour
{
    public FixedJoystick moverJoystick;
    public float velocidad;

    public Rigidbody rbLupo;
    public Animator caminarLupo;

    public bool pausarMovimientoLupo = false;

    public Transform jugador;

    [SerializeField] Animator baileLupo;

    void Update()
    {
        
        UpdateLookJoystick();
     
    }

    private void FixedUpdate()
    {
        UpdateMoveJoystick();
    }

    //Esto mueve.
    void UpdateMoveJoystick()
    {
        //float hoz = moverJoystick.Horizontal;
        //float ver = moverJoystick.Vertical;

        if (pausarMovimientoLupo == false)
        {
            Vector3 direction = new Vector3(moverJoystick.Horizontal, 0, moverJoystick.Vertical).normalized;

            //transform.position = transform.position + direction * velocidad * Time.deltaTime;

            rbLupo.AddForce(direction * velocidad, ForceMode.Acceleration);
        }
    }
  
    //Esto hace que mire.
        void UpdateLookJoystick()
    {
        if (pausarMovimientoLupo == false)
        {
            float hoz = moverJoystick.Horizontal;
            float ver = moverJoystick.Vertical;

            Vector3 direction = new Vector3(moverJoystick.Horizontal, 0, moverJoystick.Vertical).normalized;

            //Se suma porque el look tiene que mirar en la misma posición del personaje +1 porque es un vector normalizado de 0 a 1.
            //Es decir, si Lupo esta en 100/100, el look at tiene que estar en 100/101, por ejemplo.

            direction = transform.position + direction;

            //para que mire a donde se mueva. Para que mire a donde necesitamos tenemos que sumarle la posición del propio personaje en cada momento.

            transform.LookAt(direction);

            Vector2 cruceta = new Vector2(hoz, ver).normalized;
            float velocidadPaso = Vector2.Distance(Vector2.zero, cruceta);

            caminarLupo.SetFloat("esCaminar", velocidadPaso);
        }

        
        
    }

    public void Bailar()
    {
        jugador.transform.localPosition = new Vector3(13, 0.01388788f, 37.29003f);
        jugador.transform.localRotation = Quaternion.Euler(0, 270, 0);
    }

    public void FinAnimacion()
    {
        baileLupo.SetBool("Baile3", false);
        baileLupo.SetBool("Baile1", false);
        baileLupo.SetBool("Baile2", false);
    }
}
