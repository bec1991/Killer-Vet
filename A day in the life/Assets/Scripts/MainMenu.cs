using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    

    public void GoBackScenes()
    {
        SceneManager.LoadScene("");
    }

    public void Play()
    {
        SceneManager.LoadScene("SampleScene");
    }


    /*
    public void GoToOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");

    }

    /*
    public void GoToHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");

    }
    */

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
