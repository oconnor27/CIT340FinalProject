using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public int sceneNo;
   public void SceneChannger()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + sceneNo);
   }
   public void SceneQuit()
   {
    Application.Quit();
   }
}
