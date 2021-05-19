using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonProlog : MonoBehaviour
{
    public void MulaiGame()
    {
        SceneManager.LoadScene("Level 1");
    }
}