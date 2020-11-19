using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorQue : MonoBehaviour
{
    public Text text;
    public GameObject win;
    public PlayerMove playerMove;
    public GameObject[] questions;

    public int correctQuestions = 0; // Esta es la que enviamos al SQL

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Pregunta: "+correctQuestions.ToString()+"/12";
        if (correctQuestions >= 12)
        {
            win.SetActive(true);
            for (int i = 0; i < questions.Length; i++)
            {
                questions[i].SetActive(false);
            }
            playerMove.activatePause = true;
        }
    }
}
