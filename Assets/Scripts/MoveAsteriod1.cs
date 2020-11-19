using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAsteriod1 : MonoBehaviour
{
    // Update is called once per frame
    private void Start()
    {
        transform.position = new Vector3(Random.Range(-206f, 206f), transform.position.y, transform.position.z);
    }
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, -150, 1);
    }
}
