using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hasil : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LeaveGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
