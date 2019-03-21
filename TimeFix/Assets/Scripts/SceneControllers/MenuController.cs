using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{

    public void InizioGioco()
    {
        SceneManager.LoadScene("Livello1", LoadSceneMode.Single);
    }
}
