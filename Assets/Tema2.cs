using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tema2 : MonoBehaviour
{
    public string nombre;
    public int anio;
    public string orientacion;
    // Start is called before the first frame update
    void Start()
    {
        if (nombre == "")
        {
            Debug.Log("Error, no completaste el campo nombre");
        }
        else if (anio < 1 || anio > 5)
        {
            Debug.Log("Error, el año que ingresaste no es valido");
        }
        else if(anio < 3 || anio > 5)
        {
            Debug.Log("Error, aun estas en ciclo basico");
        }
        else
        {
            switch (orientacion)
            {
                case "T":
                    Debug.Log("¡Muchas gracias " + nombre + "!");
                    break;
                case "D":
                    Debug.Log("¡Muchas gracias " + nombre + "!");
                    break;
                case "G":
                    Debug.Log("¡Muchas gracias " + nombre + "!");
                    break;
                case "H":
                    Debug.Log("¡Muchas gracias " + nombre + "!");
                    break;
                case "M":
                    Debug.Log("¡Muchas gracias " + nombre + "!");
                    break;
                default:
                    Debug.Log("Error, el valor que ingresaste no es valido, sólo se puede ingresar la inicial en mayúscula de la especialidad");
                    break;
            }
        }

        
        
        
        
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
