using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InserPasswordContemporary : MonoBehaviour
{
    public InputField passwordA,passwordB;
    public string targetPassword;
    public GameObject sfera;

    private void FixedUpdate()
    {
        if (passwordA.IsActive() && passwordB.IsActive()&&passwordB.text.Equals(targetPassword)&& passwordA.text.Equals(targetPassword)) {
            sfera.gameObject.SetActive(true);
            //cancellazione da inventario mancante I due libri come ci si avvicina devono attivare l inputfield e com e ti allontani sparisce
        }
    }

}
