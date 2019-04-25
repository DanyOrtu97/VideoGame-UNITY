﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerFlooded : MonoBehaviour
{
    public GameObject luceCentrale;
    public GameObject portale;
    private bool inventoryEnabledA = true, inventoryEnabledB = true;
    public GameObject InterfaceCollectibleA, InterfaceCollectibleB;
    public GameObject infoA;
    public GameObject colliderUscita;
    public GameObject videoIntro, liam, remy, interfacciaUtente, descrizioneIntro;
    public int[] CollectibleA;
    private int indiceA = 0;
    public int[] CollectibleB;
    private int indiceB = 0;
    public Image sprite1A, sprite2A, sprite3A;
    public Image sprite1B, sprite2B, sprite3B;
    public GameObject intro;
    public Text InteractionClose;
    private int contaLuci = 0;
    private int contaChiavi;
    private float timeIntro = 0.0f;
    private int contaInizio = 0;
    private bool skip = false;
    public GameObject skipButton;

    private List<string> listplayerNavicella = new List<string>();
    private bool lockR = false;
    private bool lockViewInventario = false;

    private void Awake()
    {
        timeIntro = Time.time;
        videoIntro.gameObject.SetActive(true);
        liam.gameObject.SetActive(false);
        remy.gameObject.SetActive(false);
        interfacciaUtente.gameObject.SetActive(false);
        descrizioneIntro.gameObject.SetActive(false);

    }


    // Start is called before the first frame update
    void Start()
    {
        indiceA = 0;
        CollectibleA = new int[] { 4, 4, 4 };
        indiceB = 0;
        CollectibleB = new int[] { 4, 4, 4 };
        this.gameObject.GetComponent<SaveLoad>().Save();
        InteractionClose.text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per continuare!";
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - timeIntro > 60 && contaInizio == 0) || skip)
        {
            skip = false;
            skipButton.gameObject.SetActive(false);
            videoIntro.gameObject.SetActive(false);
            liam.gameObject.SetActive(true);
            remy.gameObject.SetActive(true);
            interfacciaUtente.gameObject.SetActive(true);
            descrizioneIntro.gameObject.SetActive(true);
            contaInizio++;
        }
        if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
        {
            intro.SetActive(false);
        }

        //INTERFACE a 
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




        //INTERFACE b
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

    public void AddLight()
    {

        contaLuci++;
        if (contaLuci == 4)
        {
            luceCentrale.gameObject.GetComponent<Light>().enabled = true;
            portale.gameObject.SetActive(true);
            colliderUscita.gameObject.SetActive(true);
        }
    }

    public void RaccogliChiave()
    {
        contaChiavi++;
    }

    public bool IsOpenRecinto()
    {
        return contaChiavi == 1;
    }


    public void collectibleA()
    {
        if (indiceA < 3)
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
            }
            indiceA++;
        }
    }

    public void collectibleB()
    {
        if (indiceB < 3)
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
            }
            indiceB++;
        }
    }
    public void AddNavicella(string player)
    {
        listplayerNavicella.Add(player);
        if (listplayerNavicella.Contains("PlayerA") && listplayerNavicella.Contains("PlayerB") && lockR == false)
        {
            lockR = true;
            this.gameObject.GetComponent<ChangeSceneAsync>().ChangeScene("Livello4Laboratory");

        }
    }
    public void pressSkip()
    {
        skip = true;
    }

}
