using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreIncrease : MonoBehaviour
{
     public static ScoreIncrease instance;
        private int score = 0;
    public Text scoreText;
     private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AddScore(int amount)
    {
        score += amount;
        FixedUpdate();
    }
    // Update is called once per frame
    public void FixedUpdate()
    {
        scoreText.text = "0" + score.ToString();
    }
}
