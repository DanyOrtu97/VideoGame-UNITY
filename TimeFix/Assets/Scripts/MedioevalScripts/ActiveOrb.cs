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


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerB"))
        {
            alertGUI.gameObject.SetActive(true);
            alertGUI.gameObject.GetComponent<Text>().text = "Premi E per attivare la sfera";

        }
    }

    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("PlayerB"))
        { 


            if (isOrbActive == false)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (player.gameObject.GetComponent<Inventory>().checkItem("blueorbPorto")&& player.gameObject.GetComponent<Inventory>().checkItem("redorb") && player.gameObject.GetComponent<Inventory>().checkItem("greenorb") )
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