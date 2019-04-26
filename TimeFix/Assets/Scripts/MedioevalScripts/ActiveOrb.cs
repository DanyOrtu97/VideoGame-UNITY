using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ActiveOrb : MonoBehaviour
{
    public GameObject player;
    public Text alertGUI;
    private bool isOrbActive = false;
    public GameObject gameController;
    public GameObject finelvlporto;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            alertGUI.gameObject.SetActive(true);
            alertGUI.gameObject.GetComponent<Text>().text = "Premi " + InputAssign.keyDictInteractString["PlayerBInteract"] + " per attivare la sfera e ricaricare il dispositivo ";

        }
    }

    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("PlayerB"))
        { 


            if (isOrbActive == false)
            {
                if (Input.GetKeyDown(InputAssign.keyDictInteract["PlayerBInteract"]))
                {
                    if (player.gameObject.GetComponent<Inventory>().checkItem("blueorbPorto")
                        && player.gameObject.GetComponent<Inventory>().checkItem("redorb") 
                        && player.gameObject.GetComponent<Inventory>().checkItem("greenorb") 
                        && finelvlporto.gameObject.GetComponent<EndLevel1>().isOnBoat())
                    {

                        isOrbActive = true;

                        player.gameObject.GetComponent<Inventory>().removeItemByType("redorb");
                        player.gameObject.GetComponent<Inventory>().removeItemByType("blueorbPorto");
                        player.gameObject.GetComponent<Inventory>().removeItemByType("greenorb");

                        alertGUI.gameObject.SetActive(false);

                        gameController.gameObject.GetComponent<ChangeSceneAsync>().ChangeScene("Livello2SunTemple");
                    }
                    else
                    {
                        alertGUI.gameObject.GetComponent<Text>().text = "Ti servono le 3 sfere";
                        if (finelvlporto.gameObject.GetComponent<EndLevel1>().isOnBoat() == false)
                        {
                            alertGUI.gameObject.GetComponent<Text>().text += " \n Attendi che Liam sia in viaggio";
                        }
                        
                    }
                }
            }




        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            alertGUI.gameObject.SetActive(false);
        }
    }

}