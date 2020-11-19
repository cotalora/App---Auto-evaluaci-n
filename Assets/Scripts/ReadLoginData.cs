using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReadLoginData : MonoBehaviour
{
    public Text nombre;
    public Text apellido;
    public Text correo;
    public Text codigo;

    public string pNombre;
    public string sNombre;
    public string pApellido;
    public string sApellido;

    public GameObject errorText;

    public LoginData loginData;

    float count = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (errorText.activeSelf)
        {
            count += Time.deltaTime;
            if (count >= 3)
            {
                errorText.SetActive(false);
                count = 0;
            }
        }
    }

    public void ReadData()
    {
        if (nombre.text == "")
        {
            errorText.SetActive(true);
            errorText.GetComponent<Text>().text = "Es necesario el nombre";
        }
        else if (apellido.text == "")
        {
            errorText.SetActive(true);
            errorText.GetComponent<Text>().text = "Es necesario el apellido";
        }
        else if (codigo.text == "")
        {
            errorText.SetActive(true);
            errorText.GetComponent<Text>().text = "Es necesario el código";
        }
        else if (correo.text == "")
        {
            errorText.SetActive(true);
            errorText.GetComponent<Text>().text = "Es necesario el correo";
        }
        else if ((correo.text.IndexOf("@ucundinamarca.edu.co") < 0 && correo.text.IndexOf("@UCUNDINAMARCA.EDU.CO") < 0) || (correo.text.IndexOf("@UCUNDINAMARCA.EDU.CO") < 0 && correo.text.IndexOf("@ucundinamarca.edu.co") < 0))
        {
            errorText.SetActive(true);
            errorText.GetComponent<Text>().text = "Es necesario el correo institucional";
        }
        else
        {

            //Verificar si hay más de 2 nombres

            string[] splitAr = nombre.text.Split(char.Parse(" "));

            pNombre = splitAr[0];

            if (splitAr.Length >= 3)
            {
                sNombre = splitAr[1] + " " + splitAr[2];
            }
            else if (splitAr.Length == 1)
            {
                sNombre = "";
            }
            else
            {
                sNombre = splitAr[1];
            }
            

            //Verificar si hay más de 2 apellidos

            string[] splitArA = apellido.text.Split(char.Parse(" "));

            pApellido = splitArA[0];

            if (splitArA.Length >= 3)
            {
                sApellido = splitArA[1] + " " + splitArA[2];
            }
            else if (splitArA.Length == 1)
            {
                sApellido = "";
            }
            else
            {
                sApellido = splitArA[1];
            }

            loginData.pNombre = pNombre;
            loginData.sNombre = sNombre;
            loginData.pApellido = pApellido;
            loginData.sApellido = sApellido;
            loginData.correo = correo.text;
            loginData.codigo = codigo.text;

            StartCoroutine(loginData.Register());
        }
        
    }
}
