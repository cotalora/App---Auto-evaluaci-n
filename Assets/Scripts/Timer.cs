using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PRUEBA : MonoBehaviour
{

    float timer = 5;
    public Text count;

    public GameObject generator;
    public GameObject generatorQuestion;

    // Start is called before the first frame update
    void Start()
    {
        generator.SetActive(false);
        generatorQuestion.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        int tim = Mathf.RoundToInt(timer);
        count.text = tim.ToString();

        if (tim <= 0)
        {
            generator.SetActive(true);
            generatorQuestion.SetActive(true);
            gameObject.SetActive(false);
            timer = 5;
        }
    }
}
