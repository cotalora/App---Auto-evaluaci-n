using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public Camera camera;

    public GameObject rawImage;
    public GameObject splot;
    public GameObject fire;
    public GameObject again;

    public GameObject[] questions;
    public GameObject[] subQuestions;

    public int quetionNumber = 0; 

    public bool offParallax = false;

    public bool activatePause = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SubQuestions();
        if (activatePause == true)
        {
            Time.timeScale = 0f;
        } else
        {
            Time.timeScale = 1f;
        }

        if (offParallax == false)
        {
            Vector3 vector = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.position += vector * 100f * Time.deltaTime;

            if (transform.position.y >= 119f)
            {
                transform.position = new Vector3(transform.position.x, 119f, transform.position.z);
            }

            if (transform.position.y <= -115f)
            {
                transform.position = new Vector3(transform.position.x, -115f, transform.position.z);
            }

            if (transform.position.x >= 262f)
            {
                transform.position = new Vector3(262f, transform.position.y, transform.position.z);
            }

            if (transform.position.x <= -262f)
            {
                transform.position = new Vector3(-262f, transform.position.y, transform.position.z);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ast1")
        {
            offParallax = true;
            rawImage.SetActive(false);
            fire.SetActive(false);
            splot.SetActive(true);
            activatePause = true;
            again.SetActive(true);
            gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        }

        if (collision.tag == "que")
        {
            quetionNumber++;
            if (quetionNumber == 1)
            {
                questions[0].SetActive(true);
                questions[1].SetActive(false);
                questions[2].SetActive(false);
                questions[3].SetActive(false);
                questions[4].SetActive(false);
                questions[5].SetActive(false);
                activatePause = true;
                Destroy(collision.gameObject);
            }
            if (quetionNumber == 2)
            {
                questions[0].SetActive(false);
                questions[1].SetActive(true);
                questions[2].SetActive(false);
                questions[3].SetActive(false);
                questions[4].SetActive(false);
                questions[5].SetActive(false);
                activatePause = true;
                Destroy(collision.gameObject);
            }
            if (quetionNumber == 3)
            {
                questions[0].SetActive(false);
                questions[1].SetActive(false);
                questions[2].SetActive(true);
                questions[3].SetActive(false);
                questions[4].SetActive(false);
                questions[5].SetActive(false);
                activatePause = true;
                Destroy(collision.gameObject);
            }
            if (quetionNumber == 4)
            {
                questions[0].SetActive(false);
                questions[1].SetActive(false);
                questions[2].SetActive(false);
                questions[3].SetActive(true);
                questions[4].SetActive(false);
                questions[5].SetActive(false);
                activatePause = true;
                Destroy(collision.gameObject);
            }
            if (quetionNumber == 5)
            {
                questions[0].SetActive(false);
                questions[1].SetActive(false);
                questions[2].SetActive(false);
                questions[3].SetActive(false);
                questions[4].SetActive(true);
                questions[5].SetActive(false);
                activatePause = true;
                Destroy(collision.gameObject);
            }
            if (quetionNumber == 6)
            {
                questions[0].SetActive(false);
                questions[1].SetActive(false);
                questions[2].SetActive(false);
                questions[3].SetActive(false);
                questions[4].SetActive(false);
                questions[5].SetActive(true);
                activatePause = true;
                Destroy(collision.gameObject);
            }
            if (quetionNumber == 7)
            {
                questions[0].SetActive(false);
                questions[1].SetActive(false);
                questions[2].SetActive(false);
                questions[3].SetActive(false);
                questions[4].SetActive(false);
                questions[5].SetActive(false);
                activatePause = true;
                Destroy(collision.gameObject);

                subQuestions[0].SetActive(true);
                subQuestions[1].SetActive(false);
                subQuestions[2].SetActive(false);
                subQuestions[3].SetActive(false);
                subQuestions[4].SetActive(false);
                subQuestions[5].SetActive(false);
            }
        }
    }

    void SubQuestions()
    {
        if (quetionNumber == 8)
        {
            questions[0].SetActive(false);
            questions[1].SetActive(false);
            questions[2].SetActive(false);
            questions[3].SetActive(false);
            questions[4].SetActive(false);
            questions[5].SetActive(false);
            activatePause = true;

            subQuestions[0].SetActive(false);
            subQuestions[1].SetActive(true);
            subQuestions[2].SetActive(false);
            subQuestions[3].SetActive(false);
            subQuestions[4].SetActive(false);
            subQuestions[5].SetActive(false);
        }

        if (quetionNumber == 9)
        {
            questions[0].SetActive(false);
            questions[1].SetActive(false);
            questions[2].SetActive(false);
            questions[3].SetActive(false);
            questions[4].SetActive(false);
            questions[5].SetActive(false);
            activatePause = true;

            subQuestions[0].SetActive(false);
            subQuestions[1].SetActive(false);
            subQuestions[2].SetActive(true);
            subQuestions[3].SetActive(false);
            subQuestions[4].SetActive(false);
            subQuestions[5].SetActive(false);
        }

        if (quetionNumber == 10)
        {
            questions[0].SetActive(false);
            questions[1].SetActive(false);
            questions[2].SetActive(false);
            questions[3].SetActive(false);
            questions[4].SetActive(false);
            questions[5].SetActive(false);
            activatePause = true;

            subQuestions[0].SetActive(false);
            subQuestions[1].SetActive(false);
            subQuestions[2].SetActive(false);
            subQuestions[3].SetActive(true);
            subQuestions[4].SetActive(false);
            subQuestions[5].SetActive(false);
        }

        if (quetionNumber == 11)
        {
            questions[0].SetActive(false);
            questions[1].SetActive(false);
            questions[2].SetActive(false);
            questions[3].SetActive(false);
            questions[4].SetActive(false);
            questions[5].SetActive(false);
            activatePause = true;

            subQuestions[0].SetActive(false);
            subQuestions[1].SetActive(false);
            subQuestions[2].SetActive(false);
            subQuestions[3].SetActive(false);
            subQuestions[4].SetActive(true);
            subQuestions[5].SetActive(false);
        }

        if (quetionNumber == 12)
        {
            questions[0].SetActive(false);
            questions[1].SetActive(false);
            questions[2].SetActive(false);
            questions[3].SetActive(false);
            questions[4].SetActive(false);
            questions[5].SetActive(false);
            activatePause = true;

            subQuestions[0].SetActive(false);
            subQuestions[1].SetActive(false);
            subQuestions[2].SetActive(false);
            subQuestions[3].SetActive(false);
            subQuestions[4].SetActive(false);
            subQuestions[5].SetActive(true);
        }
    }
}
