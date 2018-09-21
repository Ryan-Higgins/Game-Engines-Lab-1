using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TankMove : MonoBehaviour
{
	public static float speed = 2;
	
	
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
		{
			transform.Translate(Vector3.forward * (speed*Time.deltaTime));
		}

		if (Input.GetKey((KeyCode.A)))
		{
			transform.Rotate(0,-5,0);
		}

		if (Input.GetKey(KeyCode.D))
		{
			transform.Rotate(0,5,0);
		}

		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.back*(speed * Time.deltaTime));
		}
	}
}
