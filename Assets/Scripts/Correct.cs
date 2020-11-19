using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correct : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMove playerMove;
    public GameObject correct;
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
        if (playerMove.quetionNumber == 1)
        {
            response = "Registros calificados de programas académicos de educación superior";
        }
        if (playerMove.quetionNumber == 2)
        {
            response = "Toda la comunidad universitaria";
        }
        if (playerMove.quetionNumber == 3)
        {
            response = "Visibilidad nacional e internacional, e impacto de egresados en el medio";
        }
        if (playerMove.quetionNumber == 4)
        {
            response = "- Preparación y socialización - Ponderación - Recolección de la información";
        }
        if (playerMove.quetionNumber == 5)
        {
            response = "78";
        }
        if (playerMove.quetionNumber == 6)
        {
            response = "Ingeniería de sistemas y computación";
        }
    }

    public void Correc()
    {
        correct.SetActive(true);
        contadorQue.correctQuestions++;
        for (int i = 0; i < questions.Length; i++)
        {
            questions[i].SetActive(false);
        }
        StartCoroutine(SendDataIn());
    }

    public void next()
    {
        playerMove.activatePause = false;
        confirm.SetActive(false);
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
