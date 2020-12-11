using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactAnimaPorco : MonoBehaviour {

	private Animator animacoes;
	private int limite = -1;
	public string[] clips;
	[SerializeField]
	private GameObject bomb, pontos1000;

	// Use this for initialization
	void Start () {

		animacoes = GetComponent<Animator> ();
	}


	void OnCollisionEnter2D(Collision2D col)
	{
		if (GAMEMANAGER.instance.jogoComecou == true) {

			if (col.relativeVelocity.magnitude > 4 && col.relativeVelocity.magnitude < 10) {
				if (limite < clips.Length - 1) {
					limite++;
					animacoes.Play (clips [limite]);
				} else if (limite == clips.Length - 1) {
					Instantiate (pontos1000, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
					Instantiate (bomb, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
					if (GAMEMANAGER.instance.numPorcosCena < 0) {
						GAMEMANAGER.instance.numPorcosCena = 0;
					}
					Destroy (gameObject);
					GAMEMANAGER.instance.numPorcosCena -= 1;

					GAMEMANAGER.instance.pontosGame += 1000;
					UIMANAGER.instance.pontosTxt.text = GAMEMANAGER.instance.pontosGame.ToString ();
				}




			} else if (col.relativeVelocity.magnitude > 10 && (col.gameObject.CompareTag ("Player"))) {
				Instantiate (pontos1000, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
				Instantiate (bomb, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);

				Destroy (gameObject);
				GAMEMANAGER.instance.numPorcosCena -= 1;



				if (GAMEMANAGER.instance.numPorcosCena < 0) {
					GAMEMANAGER.instance.numPorcosCena = 0;
				}

				GAMEMANAGER.instance.pontosGame += 1000;
				UIMANAGER.instance.pontosTxt.text = GAMEMANAGER.instance.pontosGame.ToString ();

			}
			else if (col.gameObject.CompareTag ("clone")) {
				Instantiate (pontos1000, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
				Instantiate (bomb, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);

				Destroy (gameObject);
				GAMEMANAGER.instance.numPorcosCena -= 1;



//				if (GAMEMANAGER.instance.numPorcosCena < 0) {
//					GAMEMANAGER.instance.numPorcosCena = 0;
//				}

				GAMEMANAGER.instance.pontosGame += 1000;
				UIMANAGER.instance.pontosTxt.text = GAMEMANAGER.instance.pontosGame.ToString ();
			}
		}
	}
}
