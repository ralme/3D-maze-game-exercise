using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeCount = 0;
    public Text timerText;
    public static string minutes;
    public static string seconds;

    void Update()
    {
            if (PlayerMovement.playerMoving && !WinningGame.reachedTrigger)
                timeCount += Time.deltaTime;

            minutes = ((int) timeCount / 60).ToString("00");
            seconds = (timeCount % 60).ToString("00");

            timerText.text = "Time: " + minutes + ":" + seconds;
    }
}