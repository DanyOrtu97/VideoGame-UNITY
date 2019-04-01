using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerA : MonoBehaviour
{
    
    public Text textA;
    public Image sprite1, sprite2, sprite3, sprite4, sprite5;
    public GameObject infoA;
    private Animator animator;
	private CharacterController controller;
	private float speed = 2f;
	private float jumpForce = 10f;
	private float gravity = 30f;
	private float rotation = 0f;
	private float timeToGathering = 0f;
	private float turnSpeed = 2f;
	private Vector3 moveDir;
	public bool tmp = false;
    public int[] Collectible;
	private int indice = 0;



     
	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
		controller = gameObject.GetComponent<CharacterController>();
        indice = 0;
		Collectible = new int[] { 4, 4, 4, 4, 4 };
        turnSpeed = 3f;
        speed = 3f;
    }

	// Update is called once per frame
	void FixedUpdate()
	{

        /*
		 * 
		 * movimenti
		 */
        float z = Input.GetAxis(InputAssign.keyDict["PlayerAVertical"]); 
        float x = Input.GetAxis(InputAssign.keyDict["PlayerAHorizontal"]);



        if (z != 0 && (((Time.time - timeToGathering) > 4.8) || timeToGathering == 0) /*&& !died*/)
		{
			animator.SetFloat("Velocity", z);
			animator.SetBool("Jump", true);
			animator.SetBool("IsMoving", true);
			moveDir = new Vector3(0, 0, z);
			moveDir = transform.TransformDirection(moveDir);
			moveDir *= speed;
			controller.Move(moveDir * Time.deltaTime);

			tmp = true;
		}
		else
		{
			tmp = false;
			animator.SetBool("IsMoving", false);
			animator.SetBool("Take", false);
		}

		rotation += x * turnSpeed;
		transform.eulerAngles = new Vector3(0, rotation, 0);

		if (Input.GetKeyDown(KeyCode.PageDown))
		{
			moveDir.y = jumpForce;
			animator.SetBool("Jump", true);
		}
		else
		{
			animator.SetBool("Jump", false);
		}

        /*
		if (Input.GetKeyDown(KeyCode.P) && tmp == false)
		{
			animator.SetBool("Take", true);
			timeToGathering = Time.time;
		}
        */

		moveDir.x = 0;
		moveDir.z = 0;
		moveDir.y -= gravity * Time.deltaTime;
		controller.Move(moveDir * Time.deltaTime);



		//esplosione finale
		if (Input.GetKeyDown(KeyCode.K))
		{
			Explosion();
		}

	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Collectible") && indice < 5)
		{
			other.gameObject.SetActive(false);


            Collectible[indice] = 1;

            switch (indice)
            {
                case 0 : sprite1.gameObject.SetActive(true);
                        break; 
                case 1 : sprite2.gameObject.SetActive(true);
                        break;
                case 2 : sprite3.gameObject.SetActive(true);
                        break;
                case 3 : sprite4.gameObject.SetActive(true);
                        break;
                case 4 : sprite5.gameObject.SetActive(true);
                        break;
            }
			indice++;
		}

        if (other.CompareTag("Collectible") && indice == 5)
        {
            textA.text = "Massima capienza raggiunta!";
            infoA.gameObject.SetActive(true);
        }

	}



	private void Explosion()
	{
		int conta = 0;

		for (int i = 0; i < 5; i++)
		{
			if (Collectible[i] == 1)
			{
				conta++;
			}
		}

		if (conta == 5)
		{
			Debug.Log("Esplosione atomicaA");
		}
	}
}

