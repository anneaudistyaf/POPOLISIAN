using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("StartLevel");
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("HOW TO PLAY");
    }
    public void DetailLevel()
    {
        SceneManager.LoadScene("DETAIL LEVEL");
    }
    public void Credit()
    {
        SceneManager.LoadScene("CREDIT");
    }
    public void Information()
    {
        SceneManager.LoadScene("INFORMATION");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
