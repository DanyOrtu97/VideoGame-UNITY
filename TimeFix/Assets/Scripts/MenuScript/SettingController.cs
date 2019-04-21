using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            InputAssign.UpdateDictionaryInteract("PlayerAInteract", KeyCode.E);
            InputAssign.UpdateDictionaryMovement("PlayerBHorizontal", "HorizontalB");
            InputAssign.UpdateDictionaryMovement("PlayerBVertical", "HorizontalB");
            InputAssign.UpdateDictionaryInteract("PlayerBInteract", KeyCode.Return);

            //salto
            InputAssign.UpdateDictionaryInteract("PlayerAJump", KeyCode.Space);
            InputAssign.UpdateDictionaryInteract("PlayerBJump", KeyCode.RightCommand);

            //Stringeh per i tasti
            InputAssign.UpdateDictionaryInteractString("PlayerAInteract", "E");
            InputAssign.UpdateDictionaryInteractString("PlayerBInteract", "Invio");

            descrizioneControlliA.text="Movimento: WASD\n Interazione: E";
            descrizioneControlliB.text="Movimento: Frecce \nInterazione: Invio";
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

            InputAssign.UpdateDictionaryInteractString("PlayerAInteract", "Triangolo");
            InputAssign.UpdateDictionaryInteractString("PlayerBInteract", "Triangolo");

            descrizioneControlliA.text="Movimento: Analogico\n"+"Interazione: O";
            descrizioneControlliB.text="Movimento: Analogico\n"+"Interazione: O";
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

            InputAssign.UpdateDictionaryInteractString("PlayerAInteract", "E");
            InputAssign.UpdateDictionaryInteractString("PlayerBInteract", "Triangolo");

            descrizioneControlliA.text="Movimento: WASD\n"+"Interazione: E";
            descrizioneControlliB.text="Movimento: Analogico\n"+"Interazione: O";
        }
        else if (playerA.value == 1 && playerB.value == 0)
        {
            InputAssign.UpdateDictionaryMovement("PlayerAHorizontal", "HorizontalJoystick");
            InputAssign.UpdateDictionaryMovement("PlayerAVertical", "VerticalJoystick");
            InputAssign.UpdateDictionaryInteract("PlayerAInteract", KeyCode.Joystick1Button0);
            InputAssign.UpdateDictionaryMovement("PlayerBHorizontal", "HorizontalB");
            InputAssign.UpdateDictionaryMovement("PlayerBVertical", "VerticalB");
            InputAssign.UpdateDictionaryInteract("PlayerBInteract", KeyCode.Return);

            //salto
            InputAssign.UpdateDictionaryInteract("PlayerAJump", KeyCode.Joystick1Button1);
            InputAssign.UpdateDictionaryInteract("PlayerBJump", KeyCode.RightControl);

            InputAssign.UpdateDictionaryInteractString("PlayerAInteract", "Triangolo");
            InputAssign.UpdateDictionaryInteractString("PlayerBInteract", "Invio");
            //⭙⭘
            descrizioneControlliA.text="Movimento: Analogico\n"+"Interazione: O";
            descrizioneControlliB.text="Movimento: Frecce\n"+"Interazione: Invio";
        }
    }
}
