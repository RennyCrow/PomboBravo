using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Mostra_Estrelas_Pontos : MonoBehaviour {

	private TextMeshProUGUI estrelas, estrelas2;
	private TextMeshProUGUI pontos, pontos2;

	private int[] estrelasVal;
	private int[] pontosVal;

	// Use this for initialization
	void Awake () {

		ZPlayerPrefs.Initialize ("12345678","pombobravogame");


		estrelasVal = new int[2];
		pontosVal = new int[2];

		for(int a = 0; a < 2; a++)
		{
			for(int x = 0; x <= ZPlayerPrefs.GetInt("FasesNumMestra"+(a+1));x++)
			{

				estrelasVal [a] += ZPlayerPrefs.GetInt ("Level" + x + "_Mestra" + (a + 1) + "estrelas");
				ZPlayerPrefs.SetInt ("Mestra" + (a + 1) + "Star", estrelasVal [a]);

				pontosVal [a] += ZPlayerPrefs.GetInt ("Level" + x + "_Mestra" + (a + 1) + "bestMestra" + (a + 1));
				ZPlayerPrefs.SetInt ("Mestra" + (a + 1) + "p", pontosVal [a]);

			}
		}


		estrelas = GameObject.FindWithTag ("textstar").GetComponent<TextMeshProUGUI> ();
		estrelas2 = GameObject.FindWithTag ("textstar2").GetComponent<TextMeshProUGUI> ();

		estrelas.SetText (ZPlayerPrefs.GetInt("Mestra1Star").ToString());
		estrelas2.SetText (ZPlayerPrefs.GetInt("Mestra2Star").ToString());

		pontos = GameObject.FindWithTag ("textPontos").GetComponent<TextMeshProUGUI> ();
		pontos2 = GameObject.FindWithTag ("textPontos2").GetComponent<TextMeshProUGUI> ();

		pontos.SetText (ZPlayerPrefs.GetInt("Mestra1p").ToString());
		pontos2.SetText (ZPlayerPrefs.GetInt("Mestra2p").ToString());

	}


	

}
