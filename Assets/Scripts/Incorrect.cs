using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Incorrect : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerMove playerMove;
    public GameObject incorrect;
    public GameObject[] questions;
    public GameObject confirmInc;
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

    }

    public void Incorrec()
    {

        response = EventSystem.current.currentSelectedGameObject.transform.Find("Text").GetComponent<Text>().text;
        StartCoroutine(SendDataIn());

        incorrect.SetActive(true);
        playerMove.quetionNumber = 0;
        contadorQue.correctQuestions = 0;
        for (int i = 0; i < questions.Length; i++)
        {
            questions[i].SetActive(false);
        }
        
    }

    public void next()
    {
        playerMove.activatePause = false;
        confirmInc.SetActive(false);
    }

    IEnumerator SendDataIn()
    {
        WWWForm form = new WWWForm();
        form.AddField("codigo", loginData.codigo);
        form.AddField("correo", loginData.correo);
        form.AddField("pregunta", playerMove.quetionNumber);
        form.AddField("respuesta", response);
        form.AddField("estado", 0);

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
