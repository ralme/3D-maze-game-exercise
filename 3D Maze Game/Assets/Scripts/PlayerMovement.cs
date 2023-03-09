using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static bool playerMoving = false;

    void Update()
    {
        if(!FinishGame.reachedTrigger)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-0.002f, 0f, 0f);
                playerMoving = true;
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(0.002f, 0f, 0f);
                playerMoving = true;
            }
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0f, 0f, -0.002f);
                playerMoving = true;
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0f, 0f, 0.002f);
                playerMoving = true;
            }
        }
    }
}
