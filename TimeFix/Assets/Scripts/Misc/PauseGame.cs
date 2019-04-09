using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{

    public GameObject pausa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
