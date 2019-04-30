using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*Controller Laboratory*/
public class Controller_Laboratory : MonoBehaviour
{
    public Image sprite1A, sprite2A, sprite3A, sprite4A, sprite5A;//sprite inventario
    public Image sprite1B, sprite2B, sprite3B, sprite4B, sprite5B;
    public GameObject fire1, fire2;//incendio finale
    public int[] CollectibleA;//array presente collectibles con indice per scorrere
    private int indiceA = 0;
    public int[] CollectibleB;
    private int indiceB = 0;
    public GameObject PlayerA;
    public GameObject PlayerB;
    public GameObject PlayerAOld;//liam e remy statici (per il finale)
    public GameObject PlayerBOld;
    public GameObject intro;
    public Text InteractionClose;
    public GameObject videoIntroCamera;
    public GameObject Interface;
    private float timeToIntro = 0f;
    private int contaActive = 0;
    private bool inventoryEnabledA = true, inventoryEnabledB = true;//variabili per gestione inventario
    public GameObject InterfaceCollectibleA, InterfaceCollectibleB;
    private bool skip = false;
    public GameObject skipButton;

    private void Awake()
    {
        videoIntroCamera.SetActive(true);
        intro.SetActive(false);
        Interface.SetActive(false);
        PlayerA.SetActive(false);
        PlayerB.SetActive(false);
        timeToIntro = Time.time;
    }

    // Start is called before the first frame update
    void Start()
    {
        indiceA = 0;
        CollectibleA = new int[] { 4, 4, 4, 4, 4 };
        indiceB = 0;
        CollectibleB = new int[] { 4, 4, 4, 4, 4 };
        this.gameObject.GetComponent<SaveLoad>().Save();//Salvataggio livello
        InteractionClose.text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per continuare!";
    }

    // Update is called once per frame
    void Update()
    {
        //Gestione Intro
        if ((Time.time - timeToIntro > 50 && contaActive == 0) || skip)
        {

            skip = false;
            skipButton.gameObject.SetActive(false);

            videoIntroCamera.SetActive(false);
            intro.SetActive(true);
            Interface.SetActive(true);
            PlayerA.SetActive(false);
            PlayerB.SetActive(false);
            contaActive++;

        }

        if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
        {
            intro.SetActive(false);
            PlayerA.SetActive(true);
            PlayerB.SetActive(true);
        }

        //Gestione inventari A
        if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInventario"]) && inventoryEnabledA)
        {

            inventoryEnabledA = !inventoryEnabledA;

            InterfaceCollectibleA.SetActive(false);
        }
        else if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInventario"]) && !inventoryEnabledA)
        {

            inventoryEnabledA = !inventoryEnabledA;
            InterfaceCollectibleA.SetActive(true);

        }


        //Gestione inventari A
        if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInventario"]) && inventoryEnabledB)
        {
            inventoryEnabledB = !inventoryEnabledB;

            InterfaceCollectibleB.SetActive(false);
        }
        else if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInventario"]) && !inventoryEnabledB)
        {
            inventoryEnabledB = !inventoryEnabledB;
            InterfaceCollectibleB.SetActive(true);

        }
    }



    public void collectibleA()
    {
        if (indiceA < 5)
        {
            CollectibleA[indiceA] = 1;

            switch (indiceA)
            {
                case 0:
                    sprite1A.gameObject.SetActive(true);
                    break;
                case 1:
                    sprite2A.gameObject.SetActive(true);
                    break;
                case 2:
                    sprite3A.gameObject.SetActive(true);
                    break;
                case 3:
                    sprite4A.gameObject.SetActive(true);
                    break;
                case 4:
                    sprite5A.gameObject.SetActive(true);
                    break;
            }
            indiceA++;
        }
    }

    public void collectibleB()
    {
        if (indiceB < 5)
        {
            CollectibleB[indiceB] = 1;

            switch (indiceB)
            {
                case 0:
                    sprite1B.gameObject.SetActive(true);
                    break;
                case 1:
                    sprite2B.gameObject.SetActive(true);
                    break;
                case 2:
                    sprite3B.gameObject.SetActive(true);
                    break;
                case 3:
                    sprite4B.gameObject.SetActive(true);
                    break;
                case 4:
                    sprite5B.gameObject.SetActive(true);
                    break;
            }
            indiceB++;
        }
    }

    public void Explosion()//Controllo fine livello
    {
        int conta = 0;

        for (int i = 0; i < 5; i++)
        {
            if (CollectibleA[i] == 1)
            {
                conta++;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (CollectibleB[i] == 1)
            {
                conta++;
            }
        }

        if (conta == 10)
        {
            fire1.SetActive(true);
            fire2.SetActive(true);
            PlayerBOld.gameObject.GetComponent<Animator>().SetBool("Died", true);
            PlayerAOld.gameObject.GetComponent<Animator>().SetBool("Died", true);
            Invoke("changeSceneWin", 6);
        }
        else
        {
            PlayerB.gameObject.GetComponent<Animator>().SetBool("Died", true);
            PlayerA.gameObject.GetComponent<Animator>().SetBool("Died", true);
            PlayerB.gameObject.GetComponent<PlayerControllerB>().setDied(true);
            PlayerA.gameObject.GetComponent<PlayerControllerA>().setDied(true);
            Invoke("changeSceneGameOver", 4);

        }

    }

    public bool ExplosionTrue()//Booleano condizioni di fine livello
    {
        int conta = 0;

        for (int i = 0; i < 5; i++)
        {
            if (CollectibleA[i] == 1)
            {
                conta++;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (CollectibleB[i] == 1)
            {
                conta++;
            }
        }

        if (conta == 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public int getIndiceA()
    {
        return indiceA;
    }

    public int getIndiceB()
    {
        return indiceB;
    }

    public void changeSceneGameOver()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }

    public void changeSceneWin()
    {
        SceneManager.LoadScene("Win", LoadSceneMode.Single);
    }

    public void pressSkip()
    {
        skip = true;
    }

}
