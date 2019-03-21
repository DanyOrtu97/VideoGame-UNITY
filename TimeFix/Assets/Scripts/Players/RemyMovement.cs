using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemyMovement : MonoBehaviour
{

	private AnimatorStateInfo currentBaseState;
	private Animator animator;
	private Rigidbody rb;
	public float speed = 1f;
	public float velocity = 0;
	public float turnSpeed = 1f;
	public float turnVelocity = 0.1f;
	public float timeToGathering = 0f;
	public float jumpForce = 0f;
	public float timeToKick = 0f;
	public float timeToJump = 0f;
	public float timeToPunch = 0f;
	public bool isGroundid = true;
	public bool tmp = false;
	public int life = 100;
	public bool died = false;
	public CapsuleCollider capsuleCollider;


	static int JumpStop = Animator.StringToHash("Base Layer.Jumping");
	static int Kick = Animator.StringToHash("Base Layer.Kicking");
	static int Punch = Animator.StringToHash("Base Layer.Punching");

	// Start is called before the first frame update
	void Start()
	{
		jumpForce = 33f;
		animator = GetComponent<Animator>();
		capsuleCollider = GetComponent<CapsuleCollider>();
		rb = this.gameObject.GetComponent<Rigidbody>();
	}

	// Update is called once per frame

	void FixedUpdate()
	{

		currentBaseState = animator.GetCurrentAnimatorStateInfo(0);

		float y = Input.GetAxis("Vertical");
		float x = Input.GetAxis("Horizontal");
		velocity = y * speed;

		if (currentBaseState.nameHash == Kick)
		{
			animator.SetBool("Kick", false);
		}

		if (currentBaseState.nameHash == Punch)
		{
			animator.SetBool("Punch", false);
		}



		turnVelocity = x * turnSpeed;

		if (!died && isGroundid)
		{
			Vector3 rotationToApply = new Vector3(0, turnVelocity, 0);

			rb.rotation = Quaternion.Euler(rb.rotation.eulerAngles + rotationToApply);

			animator.SetFloat("TurnRate", x);
		}

		if (velocity != 0 && (((Time.time - timeToGathering) > 4.8) || timeToGathering == 0)
			&& currentBaseState.nameHash != JumpStop
			&& (((Time.time - timeToKick) > 2) || timeToKick == 0)
			&& (((Time.time - timeToPunch) > 1.3) || timeToPunch == 0)
			&& isGroundid
			&& !died)
		{
			timeToPunch = 0f;
			timeToKick = 0f;
			timeToGathering = 0f;

			animator.SetBool("Take", false);
			animator.SetBool("IsMoving", true);
			animator.SetFloat("Velocity", y);

			tmp = true;

			rb.velocity = transform.forward * velocity;


			if (animator.GetBool("Jump"))
			{
				rb.AddForce(Vector3.up * (jumpForce), ForceMode.Impulse);
			}
		}
		else
		{
			animator.SetBool("IsMoving", false);
			animator.SetBool("Take", false);
			tmp = false;
		}




		if (Input.GetKeyDown(KeyCode.F) && tmp == false)
		{
			animator.SetBool("Take", true);
			timeToGathering = Time.time;
		}


		if (Input.GetKeyDown(KeyCode.Space) && isGroundid)
		{
			animator.SetBool("Jump", true);
			rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		}
		else
		{
			animator.SetBool("Jump", false);
		}



		if (life <= 0)
		{
			animator.SetBool("Died", true);
			capsuleCollider.direction = 2;
			capsuleCollider.radius = (float)0.5;
			capsuleCollider.height = 5;
			capsuleCollider.center = new Vector3(0, 2, 0);
			died = true;
		}




		if (!animator.GetBool("Fight") && Input.GetKeyDown(KeyCode.G))
		{
			animator.SetBool("Fight", true);

		}
		else if (animator.GetBool("Fight") && Input.GetKeyDown(KeyCode.G))
		{
			animator.SetBool("Fight", false);

		}

		if (Input.GetKeyDown(KeyCode.Q))
		{
			timeToKick = Time.time;
			animator.SetBool("Kick", true);
			animator.SetBool("Punch", false);
		}

		if (Input.GetKeyDown(KeyCode.E))
		{
			timeToPunch = Time.time;
			animator.SetBool("Punch", true);
			animator.SetBool("Kick", false);
		}

	}

	private void OnCollisionEnter(Collision collision)
	{

		if (collision.gameObject.name == "Sphere" && !animator.GetBool("Fight"))
		{
			life -= 20;
			Debug.Log(life);
		}

		isGroundid = true;
	}

	private void OnCollisionExit(Collision collision)
	{
		isGroundid = false;
	}

	private void OnCollisionStay(Collision collision)
	{
		isGroundid = true;
	}



}
