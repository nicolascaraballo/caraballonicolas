using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Salir_del_juego : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); //sale del juego. No lo pausa.
        }
    }
}


