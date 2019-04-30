using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Game Controller Villaggio, per la gestione dei collectibles*/
public class GameController2 : MonoBehaviour
{

    private int ironCounter = 0;
    private int toolCounter = 0;
    private int hammerCounter = 0;



    public int getCounterIron()
    {
        return ironCounter;
    }

    public void setCounterIron()
    {
        ironCounter++;
    }


    public int getCounterTool()
    {
        return toolCounter;
    }

    public void setCounterTool()
    {
        toolCounter++;
    }

    public int getCounterHammer()
    {
        return hammerCounter;
    }

    public void setCounterHammer()
    {
        hammerCounter++;
    }
}
