using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PausaAudio : MonoBehaviour {

	public Image btn;


	void Update()
	{
		if (AUDIOMANAGER.instance.pause == 1) {
			btn.color = new Color (0.2f, 0.2f, 0.2f, 0.5f);
		} else {

			btn.color = new Color (1,1,1,1);
		}
	}

	public void PauseSom()
	{
		AUDIOMANAGER.instance.pause *= -1;
		BTN_Confs.instance.liga = false;
		BTN_Confs.instance.animaConf.Play ("ConfAnimInvers");
		BTN_Confs.instance.animaEngre.Play ("AnimaEngrenagemInvers");
	}
}
