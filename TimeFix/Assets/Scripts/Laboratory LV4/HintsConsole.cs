using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintsConsole : MonoBehaviour
{

	public GameObject hintA, hintB;
	public GameObject PlayerA, PlayerB;


	// Start is called before the first frame update
	void Start()
    {
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.CompareTag("Player1") && PlayerA.GetComponent<PlayerControllerA>().openHint)
		{
			hintA.SetActive(true);
		}


		if (collision.gameObject.CompareTag("Player2") && PlayerB.GetComponent<PlayerControllerA>().openHint)
		{
			hintB.SetActive(true);
		}
	}
}
