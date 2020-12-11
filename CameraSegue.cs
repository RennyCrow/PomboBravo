using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour {


	private float t = 1;

	
	// Update is called once per frame
	void Update () {
							
		if(GAMEMANAGER.instance.jogoComecou)
		{
			if (transform.position.x != GAMEMANAGER.instance.objE.position.x && GAMEMANAGER.instance.passaroLancado == false) {
				t -= 0.1f * Time.deltaTime;

				transform.position = new Vector3 (Mathf.SmoothStep (GAMEMANAGER.instance.objE.position.x, Camera.main.transform.position.x, t), this.transform.position.y, this.transform.position.z);
			} else {

				t = 1;
			}
		}



	}


}
