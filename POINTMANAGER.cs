using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POINTMANAGER : MonoBehaviour {

	public static POINTMANAGER instance;

	void Awake()
	{
		if(instance == null)
		{
			instance = this;
			DontDestroyOnLoad (this.gameObject);
		}
		else
		{
			Destroy (gameObject);
		}
	}


	public void MelhorPontuacaoSave(string level,int pt)
	{
		if (!ZPlayerPrefs.HasKey (level + "best" + ONDEESTOU.instance.faseMestra)) {
			ZPlayerPrefs.SetInt (level + "best" + ONDEESTOU.instance.faseMestra, pt);
		} else {
			if(GAMEMANAGER.instance.pontosGame > ZPlayerPrefs.GetInt(level + "best" + ONDEESTOU.instance.faseMestra))
			{
				ZPlayerPrefs.SetInt (level + "best" + ONDEESTOU.instance.faseMestra, GAMEMANAGER.instance.pontosGame);
			}
		}
	}

	public int MelhorPontuacaoLoad(string level)
	{
		if (ZPlayerPrefs.HasKey (level + "best" + ONDEESTOU.instance.faseMestra)) {
			return ZPlayerPrefs.GetInt (level + "best" + ONDEESTOU.instance.faseMestra);
		} else {
			return 0;
		}
	}
}
