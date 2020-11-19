using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectSub : MonoBehaviour
{
    public PlayerMove playerMove;
    public GameObject[] questions;
    public GameObject confirm;
    public ContadorQue contadorQue;
    string response = "";

    GameObject dataUser;
    LoginData loginData;

    void Start()
    {
        dataUser = GameObject.Find("LoginData");
        loginData = dataUser.GetComponent<LoginData>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMove.quetionNumber == 7)
        {
            response = "Registros calificados de programas académicos de educación superior";
        }
        if (playerMove.quetionNumber == 8)
        {
            response = "Toda la comunidad universitaria";
        }
        if (playerMove.quetionNumber == 9)
        {
            response = "Visibilidad nacional e internacional, e impacto de egresados en el medio";
        }
        if (playerMove.quetionNumber == 10)
        {
            response = "- Preparación y socialización - Ponderación - Recolección de la información";
        }
        if (playerMove.quetionNumber == 11)
        {
            response = "78";
        }
        if (playerMove.quetionNumber == 12)
        {
            response = "Ingeniería de sistemas y computación";
        }
    }

    public void Correc()
    {
        contadorQue.correctQuestions++;
        playerMove.quetionNumber++;
        playerMove.activatePause = false;
        StartCoroutine(SendDataIn());
    }

    IEnumerator SendDataIn()
    {
        WWWForm form = new WWWForm();
        form.AddField("codigo", loginData.codigo);
        form.AddField("correo", loginData.correo);
        form.AddField("pregunta", contadorQue.correctQuestions);
        form.AddField("respuesta", response);
        form.AddField("estado", 1);

        WWW www = new WWW("https://invensoft.tech/AutoEvaluacion/sendDataInco.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("Data enviada");
        }
        else
        {
            Debug.Log("Usuario fallo " + www.text);
        }
    }
}
