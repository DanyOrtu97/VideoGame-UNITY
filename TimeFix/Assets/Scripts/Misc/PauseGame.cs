using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject pausa;

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausa.SetActive(true);
        }

    }

    public void returnGame()
    {
        pausa.SetActive(false);
    }

    public void quitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
		        Application.Quit();
        #endif
    }

    public void goToMenu()
    {
        SceneManager.LoadScene("Menu3D", LoadSceneMode.Single);
    }
}
