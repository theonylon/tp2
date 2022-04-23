using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class validarContraseña : MonoBehaviour
{
    string contraseniacorrecta;
    string contraseniaUsuario;
    public Text ingresoUsuario;
    public Text textomsj;
    public GameObject cartelitoMsj;

    // Start is called before the first frame update
    void Start()
    {
        contraseniacorrecta = "12345";
        cartelitoMsj.SetActive(false);

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
            cartelitoMsj.SetActive(true);
            textomsj.text = "bienvenido!";
            Debug.Log("bienvenido!");

        }

        else
        {
            cartelitoMsj.SetActive(true);
            textomsj.text = "contraseña incorrecta";
            Debug.Log("contraseña incorrecta");
        }
    }
}
