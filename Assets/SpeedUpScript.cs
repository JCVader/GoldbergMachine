using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpScript : MonoBehaviour 
{
	Vector3 startPosition;
	void Start () 
	{
		Time.timeScale = 10;
		startPosition = transform.position;

	}
	
	 void Update () 
	{
		if (Vector3.Distance (transform.position, startPosition) > 0.1f) 
		{
			Time.timeScale = 1;
		} 
		
	} 
}
