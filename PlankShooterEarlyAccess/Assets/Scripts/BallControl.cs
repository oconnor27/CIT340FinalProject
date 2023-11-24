using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
       private bool hasCollidedWithTank = false;
    private string lastTankTag = "";
   private float health = 10;
    
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("plank") && !collision.gameObject.GetComponent<PlankScore>().hasCollided)
        {
            ScoreIncrease.instance.AddScore(100); // Update the score
            WinLoseCondition.instance.PlankDestroyed();
            collision.gameObject.GetComponent<PlankScore>().hasCollided = true;
        }
         
        else if (collision.gameObject.CompareTag("yellowplank") && !collision.gameObject.GetComponent<YellowPlank>().hasCollided) 
        {
            health -= 5;
            if(health == 0)
            {
            ScoreIncrease.instance.AddScore(100); // Update the score
            WinLoseCondition.instance.PlankDestroyed();
            collision.gameObject.GetComponent<YellowPlank>().hasCollided = true;
            }
        }
    }
     private void Start() {
       //Invoke("OnTriggerStay2D",10);
    }
    
   public void OnTriggerStay2D(Collider2D other)
    {
        if (!hasCollidedWithTank && other.CompareTag("Tank") && other.tag != lastTankTag)
        {
            ScoreIncrease.instance.AddScore(other.GetComponent<TanksScore>().score);
            hasCollidedWithTank = true;
            lastTankTag = other.tag;
        
           
        }
    }
   
}



