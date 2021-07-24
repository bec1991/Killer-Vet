using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    public void GoBackScenes()
    {
       // SceneManager.LoadScene("");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    /*
    public void GoToOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");

    }

    */
    public void GoToNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
   

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame()
    {
        Debug.Log ("quit");
        Application.Quit();
    }
}
