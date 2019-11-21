using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Controlador_del_jugador : MonoBehaviour
{
    public void Update()
    {

    }
    //Almacena componente Rigibody del personaje del jugador
    Rigidbody rb;
    public float velocidad;
    int contador;
    int numItems_1;
    int numItems_2;

    public Text marcador;
    public Text finJuego;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        marcador.text = "Puntos:" + contador;
        finJuego.gameObject.SetActive(false);
    }

    public void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        rb.AddForce(movimiento * velocidad);

    }

    public void OnTriggerEnter(Collider other)
    {
    
       
       

        if (other.tag == "Suma 1")
        {
            Destroy(other.gameObject);
            contador = contador + 1;
            numItems_1 = numItems_1 + 1;
        }

        else if (other.tag == "Suma 2")
        {
            Destroy(other.gameObject);
            contador = contador + 2;
            numItems_2 = numItems_2 + 1;
        }

        else if (other.tag == "Resta 1")
        {
            contador = contador - 1;

        }

    

    ActualizaMarcador();
    if(numItems_1 >=8 && numItems_2 >=1)
    {
        finJuego.gameObject.SetActive(true);
        Time.timeScale = 0;
        }
}
void ActualizaMarcador()
    {
        marcador.text = "Puntos:" + contador;
    }
}
