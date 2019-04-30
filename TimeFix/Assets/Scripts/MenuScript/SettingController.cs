using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*Gestione possibili impostazioni di input scelti dall'utente*/
//0 tastiera 1 joystick
public class SettingController : MonoBehaviour
{
    public Dropdown playerA;
    public Dropdown playerB;
    public Text descrizioneControlliA;
    public Text descrizioneControlliB;
   
    public void BackToMainMenu() {
        SceneManager.LoadScene("Menu3D", LoadSceneMode.Single);
    }
    public void UpdateDropdown() {
        if (playerA.value == 0 && playerB.value == 0)
        {
            //Movimento e interazione
            InputAssign.UpdateDictionaryMovement("PlayerAHorizontal", "Horizontal");
            InputAssign.UpdateDictionaryMovement("PlayerAVertical", "Vertical");
            InputAssign.UpdateDictionaryMovement("PlayerBHorizontal", "HorizontalB");
            InputAssign.UpdateDictionaryMovement("PlayerBVertical", "VerticalB");


            //Interazione
            InputAssign.UpdateDictionaryInteract("PlayerAInteract", KeyCode.E);
            InputAssign.UpdateDictionaryInteract("PlayerBInteract", KeyCode.Return);

            //salto
            InputAssign.UpdateDictionaryInteract("PlayerAJump", KeyCode.Space);
            InputAssign.UpdateDictionaryInteract("PlayerBJump", KeyCode.RightControl);

            //Inventario
            InputAssign.UpdateDictionaryInteract("PlayerAInventario", KeyCode.Tab);
            InputAssign.UpdateDictionaryInteract("PlayerBInventario", KeyCode.RightShift);

            //Stringhe per i tasti
            InputAssign.UpdateDictionaryInteractString("PlayerAInteract", "E");
            InputAssign.UpdateDictionaryInteractString("PlayerBInteract", "Invio");

            descrizioneControlliA.text= "Movimento: WASD\nSalto: Spazio\nInterazione: E\nInventario: Tab";
            descrizioneControlliB.text= "Movimento: Frecce\nSalto: Ctrl Dx\nInterazione: Invio\nInventario: Shift Dx";
        }
        else if (playerA.value == 1 && playerB.value == 1) {
            InputAssign.UpdateDictionaryMovement("PlayerAHorizontal", "HorizontalJoystick");
            InputAssign.UpdateDictionaryMovement("PlayerAVertical", "VerticalJoystick");
            InputAssign.UpdateDictionaryInteract("PlayerAInteract", KeyCode.Joystick1Button0);
            InputAssign.UpdateDictionaryMovement("PlayerBHorizontal", "HorizontalJoystick1");
            InputAssign.UpdateDictionaryMovement("PlayerBVertical", "VerticalJoystick1");
            InputAssign.UpdateDictionaryInteract("PlayerBInteract", KeyCode.Joystick2Button0);

            //salto
            InputAssign.UpdateDictionaryInteract("PlayerAJump", KeyCode.Joystick1Button1);
            InputAssign.UpdateDictionaryInteract("PlayerBJump", KeyCode.Joystick2Button1);

            //Inventario
            InputAssign.UpdateDictionaryInteract("PlayerAInventario", KeyCode.Joystick1Button2);
            InputAssign.UpdateDictionaryInteract("PlayerBInventario", KeyCode.Joystick2Button2);

            InputAssign.UpdateDictionaryInteractString("PlayerAInteract", "Triangolo");
            InputAssign.UpdateDictionaryInteractString("PlayerBInteract", "Triangolo");

            descrizioneControlliA.text= "Movimento: Analogico\nSalto: O\nInterazione: Triangolo\nInventario: X";
            descrizioneControlliB.text= "Movimento: Analogico\nSalto: O\nInterazione: Triangolo\nInventario: X";
        }
        else if (playerA.value == 0 && playerB.value == 1)
        {
            InputAssign.UpdateDictionaryMovement("PlayerAHorizontal", "Horizontal");
            InputAssign.UpdateDictionaryMovement("PlayerAVertical", "Vertical");
            InputAssign.UpdateDictionaryInteract("PlayerAInteract", KeyCode.E);
            InputAssign.UpdateDictionaryMovement("PlayerBHorizontal", "HorizontalJoystick");
            InputAssign.UpdateDictionaryMovement("PlayerBVertical", "VerticalJoystick");
            InputAssign.UpdateDictionaryInteract("PlayerBInteract", KeyCode.Joystick1Button0);

            //salto
            InputAssign.UpdateDictionaryInteract("PlayerAJump", KeyCode.Space);
            InputAssign.UpdateDictionaryInteract("PlayerBJump", KeyCode.Joystick1Button1);

            InputAssign.UpdateDictionaryInteract("PlayerAInventario", KeyCode.Tab);
            InputAssign.UpdateDictionaryInteract("PlayerBInventario", KeyCode.Joystick1Button2);

            InputAssign.UpdateDictionaryInteractString("PlayerAInteract", "E");
            InputAssign.UpdateDictionaryInteractString("PlayerBInteract", "Triangolo");

            descrizioneControlliA.text= "Movimento: WASD\nSalto: Spazio\nInterazione: E\nInventario: Tab";
            descrizioneControlliB.text = "Movimento: Analogico\nSalto: O\nInterazione: Triangolo\nInventario: X";
        }
        else if (playerA.value == 1 && playerB.value == 0)
        {
            InputAssign.UpdateDictionaryMovement("PlayerAHorizontal", "HorizontalJoystick");
            InputAssign.UpdateDictionaryMovement("PlayerAVertical", "VerticalJoystick");
            InputAssign.UpdateDictionaryInteract("PlayerAInteract", KeyCode.Joystick1Button0);
            InputAssign.UpdateDictionaryMovement("PlayerBHorizontal", "HorizontalB");
            InputAssign.UpdateDictionaryMovement("PlayerBVertical", "VerticalB");
            InputAssign.UpdateDictionaryInteract("PlayerBInteract", KeyCode.Return);

            InputAssign.UpdateDictionaryInteract("PlayerAInventario", KeyCode.Joystick1Button2);
            InputAssign.UpdateDictionaryInteract("PlayerBInventario", KeyCode.RightShift);

            //salto
            InputAssign.UpdateDictionaryInteract("PlayerAJump", KeyCode.Joystick1Button1);
            InputAssign.UpdateDictionaryInteract("PlayerBJump", KeyCode.RightControl);

            InputAssign.UpdateDictionaryInteractString("PlayerAInteract", "Triangolo");
            InputAssign.UpdateDictionaryInteractString("PlayerBInteract", "Invio");
            
            descrizioneControlliA.text= "Movimento: Analogico\nSalto: O\nInterazione: Triangolo\nInventario: X";
            descrizioneControlliB.text= "Movimento: Frecce\nSalto: Ctrl Dx\nInterazione: Invio\nInventario: Shift Dx";
        }
    }
}
