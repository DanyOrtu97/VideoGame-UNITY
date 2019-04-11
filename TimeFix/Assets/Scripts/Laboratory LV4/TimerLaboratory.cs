using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerLaboratory : MonoBehaviour
{
    public GameObject SecretAccess;
    private float timeLeft = 60.0f;
    public GameObject textTimer;
    public GameObject gameController;


    void FixedUpdate()
    {
        if (SecretAccess.gameObject.GetComponent<VerifyRotation>().UltimateStage())
        {
            textTimer.gameObject.SetActive(true);
            timeLeft -= Time.deltaTime;
            textTimer.gameObject.GetComponent<Text>().text = ((int)timeLeft).ToString();

            if (timeLeft < 0 && !gameController.gameObject.GetComponent<Controller_Laboratory>().ExplosionTrue())
            {               
                SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
                textTimer.gameObject.SetActive(false);
            }

            if (gameController.gameObject.GetComponent<Controller_Laboratory>().ExplosionTrue())
            {
                textTimer.gameObject.SetActive(false);
            }
        }

    }
}
