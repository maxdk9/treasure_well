using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class InputManager : ScriptableSingleton<InputManager>
{

	private float _sidewaysMotion = 0.0f;

	public float sidewaysMotion
	{
		get { return _sidewaysMotion; }
	}
	
	
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 accel = Input.acceleration;
		_sidewaysMotion = accel.x;
	}
}
