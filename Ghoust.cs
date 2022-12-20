using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghoust : MonoBehaviour
{
    public GameObject ghoust;
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-3.16f, 1.16f);
            float RandY = Random.Range(transform.position.y + 25f, transform.position.y + 27f);
            transform.position = new Vector3(RandX, RandY, 0);
        }
    }

}
