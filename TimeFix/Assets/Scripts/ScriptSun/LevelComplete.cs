using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    private List<string> playerCorrect=new List<string>();

    public void RemovePlayer(string tag)
    {
        playerCorrect.Remove(tag);
    }
    public void AddPlayer(string tag)
    {
        playerCorrect.Add(tag);
        if (playerCorrect.Contains("PlayerA")&& playerCorrect.Contains("PlayerB"))
        {
            this.gameObject.GetComponent<ChangeSceneAsync>().ChangeScene("Livello4laboratory");
        }

    }
}
