using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Platform : MonoBehaviour
{
    public float forceJump;

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
            float RandX = Random.Range(-3f, -0.1f);                
            float RandY = Random.Range(transform.position.y + 20f, transform.position.y + 22f);
            transform.position = new Vector3(RandX, RandY, 0); 
        }
    }
}
