using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningGame : MonoBehaviour
{
    public GameObject UIObject;

    void Start()
    {
        UIObject.SetActive(false);
    }

    void OnTriggerEnter(Collider player)
    {
        if(player.tag == "Player")
        {
            UIObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider player)
    {
        UIObject.SetActive(false);
        Destroy(gameObject); //Destroys the object that has this script
    }
}
