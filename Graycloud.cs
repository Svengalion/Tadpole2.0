using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graycloud : MonoBehaviour
{
    public float forceJump;
    public void StartMoving()
    {
        InvokeRepeating("Moving", 0, 1);
    }
    public void Moving()
    {
        float RandX1 = Random.Range(-3.16f, 1.16f);
        float Y = transform.position.y;
        transform.position = new Vector3(RandX1, Y, 0);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Dude.instance.DudeRigid.velocity = Vector2.up * forceJump;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-3.16f, 1.16f);
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);
            transform.position = new Vector3(RandX, RandY, 0);
        }
    }
}
