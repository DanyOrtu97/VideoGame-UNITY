using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private int counterElemBarca = 0;
    private int counterFood = 0;

    public int getCounterBarca(){
        return counterElemBarca;

    }

    public void setCounterBarca(){
        counterElemBarca++;
    }

    public int getCounterFood()
    {
        return counterFood;
    }

    public void setCounterFood()
    {
        counterFood++;
    }

}
