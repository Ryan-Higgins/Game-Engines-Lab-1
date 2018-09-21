using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		StartCoroutine(Kill());
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * (5 * Time.deltaTime));
	}

	IEnumerator Kill()
	{
		
		yield return new WaitForSeconds(5);
		Destroy(gameObject);	
	}
}
