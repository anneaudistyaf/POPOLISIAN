using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuLevel : MonoBehaviour
{
    public void LevelSatu()
    {
        SceneManager.LoadScene("VideoProlog");
    }
    public void LevelDua()
    {
        SceneManager.LoadScene("VideoProlog");
    }
    public void LevelTiga()
    {
        SceneManager.LoadScene("VideoProlog");
    }
    public void BackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
