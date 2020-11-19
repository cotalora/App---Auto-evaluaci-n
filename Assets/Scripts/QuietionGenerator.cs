using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuietionGenerator : MonoBehaviour
{
    public GameObject _myPrefabs;
    public PlayerMove playerMove;

    void Start()
    {
        StartCoroutine(CreatePrefab());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CreatePrefab()
    {
        while (playerMove.offParallax == false)
        {
            GameObject clone = Instantiate(_myPrefabs) as GameObject;
            yield return new WaitForSeconds(10f);
        }
    }
}
