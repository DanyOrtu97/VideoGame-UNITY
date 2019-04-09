using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerB : MonoBehaviour
{

    private Animator animator;
	private CharacterController controller;
	public float speed = 2f;
	private float jumpForce = 10f;
	private float gravity = 40f;
	private float rotation = 0f;
	private float timeToGathering = 0f;
	public float turnSpeed = 2f;
	private Vector3 moveDir;
	public bool tmp = false;
    private bool died = false;

	// Start is called before the first frame update
	void Start()
	{
		animator = GetComponent<Animator>();
		controller = gameObject.GetComponent<CharacterController>();

    }

	// Update is called once per frame
	void FixedUpdate()
	{

        /*
		 * 
		 * movimenti
		 */


        float z = Input.GetAxis(InputAssign.keyDictMovement["PlayerBVertical"]);
        float x = Input.GetAxis(InputAssign.keyDictMovement["PlayerBHorizontal"]);



        if (z != 0 && (((Time.time - timeToGathering) > 4.8) || timeToGathering == 0) && !died)
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

		if (Input.GetKeyDown(KeyCode.Space))
		{
			moveDir.y = jumpForce;
			animator.SetBool("Jump", true);
		}
		else
		{
			animator.SetBool("Jump", false);
		}

        /*
		if (Input.GetKeyDown(KeyCode.F) && tmp == false)
		{
			animator.SetBool("Take", true);
			timeToGathering = Time.time;
		}
        */

		moveDir.x = 0;
		moveDir.z = 0;
		moveDir.y -= gravity * Time.deltaTime;
		controller.Move(moveDir * Time.deltaTime);

    }

    public bool getDied()
    {
        return died;
    }

    public void setDied(bool diedTrue)
    {
        died = diedTrue;
    }

}