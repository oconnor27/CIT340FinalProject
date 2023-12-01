using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject wall;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "ball")
        {
            wall.SetActive(false);
        }
    }
}
