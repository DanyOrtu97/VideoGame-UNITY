using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    private int playerCorrect=0;

    public  void ChangeScene()
    {
        SceneManager.LoadScene("Scene2", LoadSceneMode.Single);
    }
    public void RemovePlayer()
    {
        playerCorrect--;
    }
    public void AddPlayer()
    {
        playerCorrect++;
        if (playerCorrect == 2)
        {
            ChangeScene();
        }

    }
}
