using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountDown : MonoBehaviour
{
    public Text textDisplay;
    public float secondsLeft = 300;
    public bool takingAway = false;

    void Start()
    {
        takingAway = true; 
    }

    void Update()
    {
        if (takingAway)
        {
            if (secondsLeft > 0)
            {
                secondsLeft -= Time.deltaTime;
                DisplayTime(secondsLeft);
            }
            else
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
    
    void DisplayTime (float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        textDisplay.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
