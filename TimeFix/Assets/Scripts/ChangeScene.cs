using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private void OnClick()
    {
        SceneManager.LoadScene("Livello1", LoadSceneMode.Single);
    }
}
