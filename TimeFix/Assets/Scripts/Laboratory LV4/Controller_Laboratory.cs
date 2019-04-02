using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller_Laboratory : MonoBehaviour
{
    public Image sprite1A, sprite2A, sprite3A, sprite4A, sprite5A;
    public Image sprite1B, sprite2B, sprite3B, sprite4B, sprite5B;
    public GameObject fire1, fire2;
    public int[] CollectibleA;
    private int indiceA = 0;
    public int[] CollectibleB;
    private int indiceB = 0;

    // Start is called before the first frame update
    void Start()
    {
        indiceA = 0;
        CollectibleA = new int[] { 4, 4, 4, 4, 4 };
        indiceB = 0;
        CollectibleB = new int[] { 4, 4, 4, 4, 4 };
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void collectibleA()
    {
        if (indiceA < 5)
        {
            CollectibleA[indiceA] = 1;

            switch (indiceA)
            {
                case 0:
                    sprite1A.gameObject.SetActive(true);
                    break;
                case 1:
                    sprite2A.gameObject.SetActive(true);
                    break;
                case 2:
                    sprite3A.gameObject.SetActive(true);
                    break;
                case 3:
                    sprite4A.gameObject.SetActive(true);
                    break;
                case 4:
                    sprite5A.gameObject.SetActive(true);
                    break;
            }
            indiceA++;
        }
    }

    public void collectibleB()
    {
        if (indiceB < 5)
        {
            CollectibleB[indiceB] = 1;

            switch (indiceB)
            {
                case 0:
                    sprite1B.gameObject.SetActive(true);
                    break;
                case 1:
                    sprite2B.gameObject.SetActive(true);
                    break;
                case 2:
                    sprite3B.gameObject.SetActive(true);
                    break;
                case 3:
                    sprite4B.gameObject.SetActive(true);
                    break;
                case 4:
                    sprite5B.gameObject.SetActive(true);
                    break;
            }
            indiceB++;
        }
    }

    public void ExplosionA()
    {
        int conta = 0;

        for (int i = 0; i < 5; i++)
        {
            if (CollectibleA[i] == 1)
            {
                conta++;
            }
        }

        if (conta == 5)
        {
            fire1.SetActive(true);
            fire2.SetActive(true);
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }

        
    }

    public void ExplosionB()
    {
        int conta = 0;

        for (int i = 0; i < 5; i++)
        {
            if (CollectibleB[i] == 1)
            {
                conta++;
            }
        }

        if (conta == 5)
        {
            fire1.SetActive(true);
            fire2.SetActive(true);
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }


    public int getIndiceA()
    {
        return indiceA;
    }

    public int getIndiceB()
    {
        return indiceB;
    }


}
