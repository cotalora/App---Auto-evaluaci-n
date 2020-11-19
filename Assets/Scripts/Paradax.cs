using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paradax : MonoBehaviour
{
    public float parallaxSpeed = 0.02f;
    public RawImage backgroud;

    public PlayerMove playerMove;
    
    void Start()
    {
        
    }


    void Update()
    {
        if (playerMove.offParallax == false)
        {
            float finalSpeed = parallaxSpeed * Time.deltaTime;
            backgroud.uvRect = new Rect(0f, backgroud.uvRect.y + finalSpeed, 1, 1);
        }
        
    }

}
