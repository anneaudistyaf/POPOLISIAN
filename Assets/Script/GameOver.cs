﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
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
