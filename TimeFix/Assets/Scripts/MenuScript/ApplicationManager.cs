using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ApplicationManager : MonoBehaviour {

    public GameObject impostazioni;
    public GameObject menu;
    public GameObject credits;

    public void Quit () 
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}

    public void GoImpostazioni()
    {
        menu.SetActive(false);
        impostazioni.SetActive(true);
        credits.SetActive(false);
    }

    public void GoMenu()
    {
        menu.SetActive(true);
        impostazioni.SetActive(false);
        credits.SetActive(false);
    }

    public void goCredits()
    {
        menu.SetActive(false);
        impostazioni.SetActive(false);
        credits.SetActive(true);
    }
}
