using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerBaseMedioevo : MonoBehaviour
{
    
    
    public GameObject PlayerA;
    public GameObject PlayerB;
    public GameObject intro;
    public Text InteractionClose;
    public GameObject videoIntroCamera1;
    public GameObject videoIntroCamera2;
    public GameObject Interface;
    private float timeToIntro = 0f;
    private int contaActive = 0;
    private bool skip = false;
    public Button skipButton;
    private bool oneDescriprion = false;
    private void Awake()
    {
        videoIntroCamera1.SetActive(true);
        intro.SetActive(false);
        Interface.SetActive(false);
        PlayerA.SetActive(false);
        PlayerB.SetActive(false);
        timeToIntro = Time.time;
    }

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<SaveLoad>().Save();
        InteractionClose.text = "Premi " + InputAssign.keyDictInteractString["PlayerAInteract"] + " per continuare!";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time - timeToIntro > 35 && contaActive == 0)
        {
            videoIntroCamera1.SetActive(false);
            videoIntroCamera2.SetActive(true);
            contaActive++;
        }

        if (((Time.time - timeToIntro > 91 && contaActive == 1)||skip)&&oneDescriprion==false)
        {
            skip = false;
            oneDescriprion = true;
            skipButton.gameObject.SetActive(false);
            videoIntroCamera2.SetActive(false);
            videoIntroCamera1.SetActive(false);
            intro.SetActive(true);
            PlayerA.SetActive(false);
            PlayerB.SetActive(false);
            contaActive++;
        }

        if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerAInteract"]))
        {
            intro.SetActive(false);
            PlayerA.SetActive(true);
            PlayerB.SetActive(true);
            Interface.SetActive(true);
        }
    }
    public void pressSkip()
    {
        skip = true;
    }
}
