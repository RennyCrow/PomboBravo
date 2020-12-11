using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoadingInfo : MonoBehaviour {


	public TextMeshProUGUI txtComp;

	void Start()
	{
		
	}

	public void BtnClick(string s)
	{
		StartCoroutine (LoadGameProg(s));
	}

	IEnumerator LoadGameProg(string val)
	{
		AsyncOperation async = SceneManager.LoadSceneAsync (val);

		while(!async.isDone)
		{
			txtComp.enabled = true;
			yield return null;
		}
	}

	public void Site()
	{
		Application.OpenURL("http://www.google.com");
	}
}
