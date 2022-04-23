using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayorDeEdad : MonoBehaviour
{
    public int edadUsuario;
    // Start is called before the first frame update
    void Start()
    {
        if (edadUsuario >= 18)
        {
            Debug.Log("es mayor de edad");
        }
        else
        {
            Debug.Log("no es mayor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
