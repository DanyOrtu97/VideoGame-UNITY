using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject door;
    private float timeLeft = 100.0f;
    public GameObject textTimer;
    public bool startTimer=false;
    public GameObject liam;
    void FixedUpdate()
    {
        if (startTimer)
        {
            timeLeft -= Time.deltaTime;
            textTimer.gameObject.GetComponent<Text>().text = ((int)timeLeft).ToString();
            if (timeLeft < 0)
            {
                if (!door.gameObject.GetComponent<DoorController>().isOpen)
                {
                    liam.gameObject.GetComponent<Animator>().SetBool("Died", true);
                    liam.gameObject.GetComponent<PlayerControllerA>().setDied(true);
                    Invoke("ChangeSceneGameOver", 4);
                    
                }
                textTimer.gameObject.SetActive(false);
            }
        }

    }
    private void ChangeSceneGameOver() {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
}
