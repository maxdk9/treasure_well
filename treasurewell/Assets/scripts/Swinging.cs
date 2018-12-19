using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swinging : MonoBehaviour
{


	public float swingSensitivity = 100.0f;


	private void FixedUpdate()
	{

		Rigidbody2D rigidbody2 = GetComponent<Rigidbody2D>();
		
		if (rigidbody2==null)
		{
			Destroy(this);
			return;
			;
		}

		float swing = InputManager.instance.sidewaysMotion;
		Vector2 force=new Vector2(swing*swingSensitivity,0);
			
		
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
