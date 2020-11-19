using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncorrectSub : MonoBehaviour
{
    public PlayerMove playerMove;
    public GameObject incorrect;
    public GameObject[] subQuestions;
    public GameObject confirmInc;
    public ContadorQue contadorQue;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Incorrec()
    {
        incorrect.SetActive(true);
        playerMove.quetionNumber = 6;
        contadorQue.correctQuestions = 6;
        for (int i = 0; i < subQuestions.Length; i++)
        {
            subQuestions[i].SetActive(false);
        }
    }

    public void next()
    {
        playerMove.activatePause = false;
        confirmInc.SetActive(false);
    }
}
