using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
         if(other.gameObject.tag == "ball")
         {
              ScoreIncrease.instance.AddScore(1000);
              Destroy(gameObject);
         }
    }
}
