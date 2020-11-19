using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject[] _myPrefabs;
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
            GameObject clone = Instantiate(_myPrefabs[RandomNumber()]) as GameObject;
            yield return new WaitForSeconds(1f);
        }
    }

    int RandomNumber()
    {
        System.Random rand = new System.Random();
        return rand.Next(0, _myPrefabs.Length);
    }
}
