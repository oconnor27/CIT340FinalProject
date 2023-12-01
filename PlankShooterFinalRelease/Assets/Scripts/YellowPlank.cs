using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlank : MonoBehaviour
{
    new public ParticleSystem particleSystem;
    public AudioSource src;
      public Animator animator;
   private float life = 2;
   private float health = 10;
   public bool hasCollided = false;

   private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "ball")
        {
            src.Play();
            health -= 5;
            animator.SetTrigger("hit");
            if(health == 0){
                animator.SetTrigger("dead");
            Destroy(gameObject, life);
            Instantiate(particleSystem, transform.position, Quaternion.identity);
            }
        }
    }
}
