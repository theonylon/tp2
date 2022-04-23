using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class validarContraseña : MonoBehaviour
{
    string contraseniacorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    // Start is called before the first frame update
    void Start()
    {
        contraseniacorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarContrasenia()
    {
        contraseniaUsuario = ingresoUsuario.text;
        if (contraseniaUsuario == contraseniacorrecta)
        {
            Debug.Log("bienvenido!");

        }

        else
        {
            Debug.Log("contraseña incorrecta");
        }
    }
}
