using UnityEngine;
using System.Collections.Generic;


//static class that stores the key dictionary. The dictionary is loaded at runtime from Keybinding scripts.
//The keybinding scripts will load from the inspector unless there is a corresponding key in player prefs.
public static class KeyBindingManager {

    public static Dictionary<KeyAction, KeyCode> keyDict = new Dictionary<KeyAction, KeyCode>() {
        { KeyAction.up_P1,KeyCode.W },
        { KeyAction.down_P1,KeyCode.S},
        { KeyAction.right_P1,KeyCode.D },
        { KeyAction.left_P1,KeyCode.A},
        { KeyAction.interact_P1,KeyCode.E },
        { KeyAction.up_P2,KeyCode.UpArrow },
        { KeyAction.down_P2,KeyCode.DownArrow},
        { KeyAction.right_P2,KeyCode.RightArrow },
        { KeyAction.left_P2,KeyCode.LeftArrow},
        { KeyAction.interact_P2,KeyCode.Alpha0 }
    };

	//Returns key code
	public static KeyCode GetKeyCode(KeyAction key)
	{
		KeyCode _keyCode = KeyCode.None;
		keyDict.TryGetValue(key, out _keyCode);
		return _keyCode;
	}

	//Use in place of Input.GetKey
	public static bool GetKey(KeyAction key)
	{
		KeyCode _keyCode = KeyCode.None;
		keyDict.TryGetValue(key, out _keyCode);
		return Input.GetKey(_keyCode);
	}

	//Use in place of Input.GetKeyDown
	public static bool GetKeyDown(KeyAction key)
	{
		KeyCode _keyCode = KeyCode.None;
		keyDict.TryGetValue(key, out _keyCode);
		return Input.GetKeyDown(_keyCode);
	}

	//Use in place of Input.GetKeyUP
	public static bool GetKeyUp(KeyAction key)
	{
		KeyCode _keyCode = KeyCode.None;
		keyDict.TryGetValue(key, out _keyCode);
		return Input.GetKeyUp(_keyCode);
	}

	public static void UpdateDictionary(KeyBinding key)
	{
        if (!keyDict.ContainsKey(key.keyAction))
            keyDict.Add(key.keyAction, key.keyCode);
        else
            keyDict[key.keyAction] = key.keyCode;
	}
    public static float GetAxis(string ax,string pl) {
        if (pl.Equals("A"))
        {
            if (ax.Equals("Vertical"))
            {
                if (KeyBindingManager.GetKey(KeyAction.up_P1))
                {
                    return 1;
                }
                else if (KeyBindingManager.GetKey(KeyAction.down_P1))
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else {
                if (KeyBindingManager.GetKey(KeyAction.right_P1))
                {
                    return 1;
                }
                else if (KeyBindingManager.GetKey(KeyAction.left_P1))
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        else {
            if (ax.Equals("Vertical"))
            {
                if (KeyBindingManager.GetKey(KeyAction.up_P2))
                {
                    return 1;
                }
                else if (KeyBindingManager.GetKey(KeyAction.down_P2))
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (KeyBindingManager.GetKey(KeyAction.right_P2))
                {
                    return 1;
                }
                else if (KeyBindingManager.GetKey(KeyAction.left_P2))
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        
    }
}

//used to safe code inputs
//Add new keys to "bind" here
public enum KeyAction
{
	none,
	up_P1,
    down_P1,
    left_P1,
    right_P1,
    interact_P1,
    up_P2,
    down_P2,
    left_P2,
    right_P2,
    interact_P2
}
