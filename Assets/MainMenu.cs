using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame() {
        {
            Application.Quit();
        }
    }
    public void backToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

    public void goToSetting()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Setting Menu");
    }

    public void goToAbout()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Abouts Menu");
    }
}
