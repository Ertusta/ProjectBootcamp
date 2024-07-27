using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
   public void PlayGame()
   {
    SceneManager.LoadSceneAsync(1);
   }

   public void QuitGame()
   {
    Application.Quit();
    UnityEditor.EditorApplication.isPlaying = false;
    }
    public void RetunLobby()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

}

