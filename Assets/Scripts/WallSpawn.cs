using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{


	// Use this for initialization
	void Start ()
	{
	
		for (int x = 0; x < 5; x++)
		{
			for (int y = 0; y < 5; y++)
			{

				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.transform.position = new Vector3(x + 0.5f,y + 0.5f,0);
				cube.AddComponent<Rigidbody>();
				cube.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
