using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerFlooded : MonoBehaviour
{
    public GameObject luceCentrale;
    public GameObject portale;
    public GameObject infoA;
    public GameObject colliderUscita;
    public int[] CollectibleA;
    private int indiceA = 0;
    public int[] CollectibleB;
    private int indiceB = 0;
    public Image sprite1A, sprite2A, sprite3A;
    public Image sprite1B, sprite2B, sprite3B;
    public GameObject intro;
    public Text InteractionClose;
    private int contaLuci=0;
    private int contaChiavi;

    // Start is called before the first frame update
    void Start()
    {
        indiceA = 0;
        CollectibleA = new int[] { 4, 4, 4};
        indiceB = 0;
        CollectibleB = new int[] { 4, 4, 4};
        this.gameObject.GetComponent<SaveLoad>().Save();
        InteractionClose.text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per continuare!";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
        {
            intro.SetActive(false);
        }
    }

    public void AddLight()
    {

        contaLuci++;
        if(contaLuci == 4)
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

}
