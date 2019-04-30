using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Testo che scorre a ogni inizio livello
public class DialedText : MonoBehaviour
{

    public float letterPause ;
    string message;
    Text textComp;

    void Start()
    {
        textComp = GetComponent<Text>();
        message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char letter in message.ToCharArray())
        {
            textComp.text += letter;
            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
    }
}