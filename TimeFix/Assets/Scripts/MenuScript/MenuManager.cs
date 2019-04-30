
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/*Gestione menu*/
public class MenuManager : MonoBehaviour
{

    public GameObject impostazioni;
    public GameObject menu;
    public GameObject credits;
    public GameObject leggendaA;
    public GameObject leggendaB;

    public void Quit()
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
        leggendaA.SetActive(true);
        leggendaB.SetActive(true);
        credits.SetActive(false);
    }

    public void GoMenu()
    {
        menu.SetActive(true);
        impostazioni.SetActive(false);
        leggendaA.SetActive(false);
        leggendaB.SetActive(false);
        credits.SetActive(false);
    }

    public void goCredits()
    {
        menu.SetActive(false);
        impostazioni.SetActive(false);
        leggendaA.SetActive(false);
        leggendaB.SetActive(false);
        credits.SetActive(true);
    }
    public void nuovaPartita()
    {
        SceneManager.LoadScene("Introduzione");
    }
}
