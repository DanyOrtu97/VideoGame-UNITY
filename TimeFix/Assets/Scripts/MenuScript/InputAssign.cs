using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*Gestione assegnamento dinamico tasti*/
public class InputAssign : MonoBehaviour
{
    public static Dictionary<string, string> keyDictMovement = new Dictionary<string, string>() {//movimenti
        { "PlayerAHorizontal","Horizontal"},
        { "PlayerAVertical","Vertical"},
        { "PlayerBHorizontal","HorizontalB"},
        { "PlayerBVertical","VerticalB"},

    };
    public static Dictionary<string, KeyCode> keyDictInteract = new Dictionary<string, KeyCode>() {//interazione
        { "PlayerAInteract",KeyCode.E},
        { "PlayerBInteract",KeyCode.Return},
        { "PlayerAJump",KeyCode.Space},
        { "PlayerBJump",KeyCode.RightControl},
        { "PlayerAInventario",KeyCode.Tab},
        { "PlayerBInventario",KeyCode.RightShift},
    };
    public static Dictionary<string, string> keyDictInteractString = new Dictionary<string, string>() {//stringhe per la stampa negli allert per l'utente
        { "PlayerAInteract","E"},
        { "PlayerBInteract","Invio"},
    };
    public static void UpdateDictionaryMovement(string playerAx,string ax)
    {
        if (!keyDictMovement.ContainsKey(playerAx))
            keyDictMovement.Add(playerAx, ax);
        else
            keyDictMovement[playerAx] = ax;
    }
    public static void UpdateDictionaryInteract(string playerAx, KeyCode k)
    {
        if (!keyDictInteract.ContainsKey(playerAx))
            keyDictInteract.Add(playerAx, k);
        else
            keyDictInteract[playerAx] = k;
    }
    public static void UpdateDictionaryInteractString(string playerAx, string k)
    {
        if (!keyDictInteractString.ContainsKey(playerAx))
            keyDictInteractString.Add(playerAx, k);
        else
            keyDictInteractString[playerAx] = k;
    }

}
