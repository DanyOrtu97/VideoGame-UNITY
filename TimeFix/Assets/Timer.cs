using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject door;
    private float timeLeft = 30.0f;
    public GameObject textTimer;
    // Start is called before the first frame update



    void FixedUpdate()
    {
        timeLeft -= Time.deltaTime;
        textTimer.gameObject.GetComponent<Text>().text = ((int)timeLeft).ToString();
        if (timeLeft < 0) {
            Debug.Log("Game over");
        }

    }
}
