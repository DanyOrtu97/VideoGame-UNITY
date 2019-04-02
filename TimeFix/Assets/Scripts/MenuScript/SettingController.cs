using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingController : MonoBehaviour
{
    public Dropdown playerA;
    public Dropdown playerB;
    public void BackToMainMenu() {
        SceneManager.LoadScene("Menu3D", LoadSceneMode.Single);
    }
    public void UpdateDropdown() {
        if (playerA.value == 0 && playerB.value == 0)
        {
            InputAssign.UpdateDictionary("PlayerAHorizontal", "Horizontal");
            InputAssign.UpdateDictionary("PlayerAVertical", "Vertical");
            InputAssign.UpdateDictionary("PlayerBHorizontal", "HorizontalB");
            InputAssign.UpdateDictionary("PlayerBVertical", "HorizontalB");
        }
        else if (playerA.value == 1 && playerB.value == 1) {
            InputAssign.UpdateDictionary("PlayerAHorizontal", "HorizontalJoystick");
            InputAssign.UpdateDictionary("PlayerAVertical", "VerticalJoystick");
            InputAssign.UpdateDictionary("PlayerBHorizontal", "HorizontalJoystick1");
            InputAssign.UpdateDictionary("PlayerBVertical", "VerticalJoystick1");
        }
        else if (playerA.value == 0 && playerB.value == 1)
        {
            InputAssign.UpdateDictionary("PlayerAHorizontal", "Horizontal");
            InputAssign.UpdateDictionary("PlayerAVertical", "Vertical");
            InputAssign.UpdateDictionary("PlayerBHorizontal", "HorizontalJoystick");
            InputAssign.UpdateDictionary("PlayerBVertical", "VerticalJoystick");
        }
        else if (playerA.value == 1 && playerB.value == 0)
        {
            InputAssign.UpdateDictionary("PlayerAHorizontal", "HorizontalJoystick");
            InputAssign.UpdateDictionary("PlayerAVertical", "VerticalJoystick");
            InputAssign.UpdateDictionary("PlayerBHorizontal", "HorizontalB");
            InputAssign.UpdateDictionary("PlayerBVertical", "VerticalB");
        }
    }
}
