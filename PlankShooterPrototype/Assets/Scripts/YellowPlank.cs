using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlank : MonoBehaviour
{
      
   

   private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "ball")
        {
            Destroy(gameObject);
            }
        }
    }

