using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlankScore : MonoBehaviour
{
    new public ParticleSystem particleSystem;
    public AudioSource src;
        public Animator animator;
   private float life = 2;
   public bool hasCollided = false;

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "ball")
        {
            src.Play();
            animator.SetTrigger("Hit");
            Destroy(gameObject, life);
             Instantiate(particleSystem, transform.position, Quaternion.identity);
            
        }
    }
 
}
