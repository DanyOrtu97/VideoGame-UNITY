using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputAssign : MonoBehaviour
{
    public static Dictionary<string, string> keyDict = new Dictionary<string, string>() {
        { "PlayerAHorizontal","Horizontal"},
        { "PlayerAVertical","Vertical"},
        { "PlayerBHorizontal","HorizontalB"},
        { "PlayerBVertical","VerticalB"}
    };
    public static void UpdateDictionary(string playerAx,string ax)
    {
        if (!keyDict.ContainsKey(playerAx))
            keyDict.Add(playerAx, ax);
        else
            keyDict[playerAx] = ax;
    }

}
