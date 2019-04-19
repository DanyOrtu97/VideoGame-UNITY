using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    private Dictionary<string, string> dictPosizioni = new Dictionary<string, string>();
    private bool lockL = false;
    public void RemovePlayer(string tag,string punto)
    {
        dictPosizioni.Remove(tag);
    }
    public void AddPlayer(string tag,string punto)
    {
        if (!dictPosizioni.ContainsKey(tag))
        {
            dictPosizioni.Add(tag, punto);
            if (this.IsValid() && lockL == false)
            {
                lockL = true;
                this.gameObject.GetComponent<ChangeSceneAsync>().ChangeScene("Livello3Flooded");

            }
        }
       

    }
    private bool IsValid() {
        if (dictPosizioni["PlayerA"] != dictPosizioni["PlayerB"]) {
            return true;
        }
        return false;
    }
}
