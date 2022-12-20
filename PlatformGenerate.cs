using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{

    public GameObject Cloud;
    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();
        for (int i = 0; i < 5; i++)               
        {
            SpawnerPosition.x = Random.Range(-3f, -0.1f);  
            SpawnerPosition.y += Random.Range(2f, 3f);
            Instantiate(Cloud, SpawnerPosition, Quaternion.identity);  
        }
    }

}
