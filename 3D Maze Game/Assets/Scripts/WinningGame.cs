using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinningGame : MonoBehaviour
{
    public GameObject winningMessage;
    public Text timeElapsed;
    public static bool reachedTrigger = false;

    void Start()
    {
        winningMessage.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.tag == "Player")
        {
            reachedTrigger = true;
            winningMessage.SetActive(true);
            timeElapsed.text = "You took " + Timer.minutes + " minute(s) and " + Timer.seconds + " seconds.";
        }
    }
}
