using UnityEngine;
using System.Collections;

public class MarioControllerScript : MonoBehaviour {


	public float _maxSpeed = 10f;
	bool facingRight = true;

	Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();


	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		float move = Input.GetAxis("Horizontal") * 0.25f;

		anim.SetFloat("Speed", Mathf.Abs (move));

		// Debug.Log (move);

		this.rigidbody2D.velocity = new Vector2(move * _maxSpeed, this.rigidbody2D.velocity.y);

		if(move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();


	}

	void Flip()
	{
		facingRight = !facingRight;

		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
