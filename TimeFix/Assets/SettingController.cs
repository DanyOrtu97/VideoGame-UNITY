using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingController : MonoBehaviour
{
    public void BackToMainMenu() {
        SceneManager.LoadScene("Menu3D", LoadSceneMode.Single);
    }
}
