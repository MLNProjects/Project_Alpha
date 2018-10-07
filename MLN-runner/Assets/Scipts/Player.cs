using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float acc_mul;
	public float maxSpeed;
	private Rigidbody2D rb2d;
	
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("d"))
		{
			rb2d.velocity = new Vector2(Mathf.Min(rb2d.velocity.x + acc_mul, maxSpeed), rb2d.velocity.y);
		} else if (Input.GetKey("a"))
		{
			rb2d.velocity = new Vector2(Mathf.Max(rb2d.velocity.x - acc_mul, -maxSpeed),rb2d.velocity.y);
		}
		else {
			rb2d.velocity = new Vector2(Mathf.Lerp(rb2d.velocity.x, 0f, 0.4f), rb2d.velocity.y);
		}
		Debug.Log(rb2d.velocity);
		// float moveHorizontal=0;
		// if (Input.GetKey("d"))moveHorizontal+=1f;

		// if (Input.GetKey("a"))moveHorizontal+=-1f;
		// Debug.Log(moveHorizontal);
		// if (Mathf.Abs(moveHorizontal)<0.1f)
		// {
		// 	rb2d.AddForce(new Vector2(-10*rb2d.velocity.x,0));
		// }
		// else {
		// 	Vector2 acc = new Vector2(moveHorizontal, 0);
		// 	rb2d.AddForce(acc*acc_mul); 	
		// 	rb2d.velocity = new Vector2(Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed),rb2d.velocity.y);

		// }

	}
}
