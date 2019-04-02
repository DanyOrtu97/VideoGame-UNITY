﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject door;
    private float timeLeft = 60.0f;
    public GameObject textTimer;

    void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        textTimer.gameObject.GetComponent<Text>().text = ((int)timeLeft).ToString();
        if (timeLeft < 0) {
            if (!door.gameObject.GetComponent<DoorController>().isOpen)
            {
                Debug.Log("Game over");
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
            }
            textTimer.gameObject.SetActive(false);
        }

    }
}
