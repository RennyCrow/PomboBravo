using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exibe_e_Perde_Moedas : MonoBehaviour {

	[SerializeField]
	private TextMeshProUGUI textMoeda;
	private int val;
	[SerializeField]
	private Button btnCompra;

	// Use this for initialization
	void Awake () {

		textMoeda = GetComponent<TextMeshProUGUI>();
		val = SCOREMANAGER.instance.LoadDados ();
		textMoeda.SetText (val.ToString());
	}

	void Update()
	{
		if (val >= 50) {
			btnCompra.interactable = true;
		} else {
			btnCompra.interactable = false;
		}

	}

	public void CompraSimula()
	{
		SCOREMANAGER.instance.PerdeMoedas (50);
		val = SCOREMANAGER.instance.LoadDados ();
		textMoeda.SetText (val.ToString());
	}

}
