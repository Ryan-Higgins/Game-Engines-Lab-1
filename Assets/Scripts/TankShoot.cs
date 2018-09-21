using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShoot : MonoBehaviour
{
	public GameObject bullet;
	private GameObject bulletClone;
	private GameObject firePoint;
	
	// Use this for initialization
	void Start ()
	{
		firePoint = GameObject.Find("FirePoint");
		bulletClone = bullet;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(bulletClone, firePoint.transform.position, firePoint.transform.rotation);
		}
	}
}
