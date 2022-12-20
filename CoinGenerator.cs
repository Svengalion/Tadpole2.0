using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject Coin;
    void Start()
    {
        Vector3 SpawnerPosition = new Vector3();
        for (int i = 0; i < 3; i++)
        {
            SpawnerPosition.x = Random.Range(-3.5f, -0.1f);
            SpawnerPosition.y += Random.Range(2f, 3f);
            Instantiate(Coin, SpawnerPosition, Quaternion.identity);
        }
    }
}
