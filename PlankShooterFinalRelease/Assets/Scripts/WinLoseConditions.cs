using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WinLoseCondition : MonoBehaviour
{public Text ballText;
    public static WinLoseCondition instance;
    public int totalBalls = 5;
    public int totalPlanks = 3;

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

    public void Start()
    {
        ballText.text = "" + totalBalls.ToString();
    }

    public void BallsUsed()
    {
        totalBalls--;
        ballText.text = "" + totalBalls.ToString();

        if (totalBalls == 0 && totalPlanks > 0)
        {
            StartCoroutine(RestartSceneAfterDelay(2f));
        }
    }

    public void PlankDestroyed()
    {
        totalPlanks--;

        if (totalBalls >= 0 && totalPlanks == 0)
        {
            StartCoroutine(LoadNextSceneAfterDelay(4f));
        }
    }

    IEnumerator RestartSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator LoadNextSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
