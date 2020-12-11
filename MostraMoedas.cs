using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MostraMoedas : MonoBehaviour {


	[SerializeField]
	private TextMeshProUGUI textMoeda;
	private int val;


	void Awake () {

		textMoeda = GetComponent<TextMeshProUGUI>();
		val = SCOREMANAGER.instance.LoadDados ();
		textMoeda.SetText (val.ToString());
	}


}
