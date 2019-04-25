using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InserPasswordContemporary : MonoBehaviour
{
    public InputField passwordA,passwordB;
    public string targetPassword;
    public GameObject sfera;
    public bool activeSphere=false;
    public GameObject player;

    private void FixedUpdate()
    {
        if (passwordA.IsActive() && passwordB.IsActive()&&passwordB.text.Equals(targetPassword)&& passwordA.text.Equals(targetPassword) && player.gameObject.GetComponent<Inventory>().checkItem("blueorbPorto")) {
            sfera.gameObject.SetActive(true);
            passwordA.gameObject.SetActive(false);
            passwordB.gameObject.SetActive(false);
            activeSphere = true;
            player.gameObject.GetComponent<Inventory>().removeItemByType("blueorbPorto");
            passwordA.text = "";
            passwordB.text = "";
        }
    }

}
