using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*Controller Game Over*/
public class GameOverControl : MonoBehaviour
{
    public void Ritenta() {
        SceneManager.LoadScene("Menu3D", LoadSceneMode.Single);//Quando si avrà il salvataggio al click si riporta all'ultimo livello giocato.
    }
    public void MenuPrincipale()
    {
        SceneManager.LoadScene("Menu3D", LoadSceneMode.Single);
    }
}
