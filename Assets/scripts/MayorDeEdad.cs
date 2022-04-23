using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MayorDeEdad : MonoBehaviour
{
    public int edadUsuario;
    public Text mitexto;
    // Start is called before the first frame update
    void Start()
    {
        if (edadUsuario >= 18)
        {
            mitexto.text = "es mayor de edad";
            Debug.Log("es mayor de edad");
        }
        else
        {
            mitexto.text = "no es mayor de edad";
            Debug.Log("no es mayor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
