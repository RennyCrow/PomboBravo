using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorteTudo : MonoBehaviour {



	// Use this for initialization
	void Start () {

		StartCoroutine (morte());
	}	


	IEnumerator morte()
	{
		yield return new WaitForSeconds (5);
		Destroy (gameObject);
	}
}
