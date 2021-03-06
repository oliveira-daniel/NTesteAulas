﻿using UnityEngine;
using System.Collections;

public class MoverPersonagem : MonoBehaviour
{

	public float velocidade = 0.01f;
	public GameObject saida, chegada;
	Vector2 direcao;

	// Use this for initialization
	void Start ()
	{
		transform.position = new Vector2 (
			saida.transform.position.x,
			transform.position.y
		);

		if (chegada.transform.position.x < transform.position.x) {
			direcao = Vector2.left;
			transform.localScale = new Vector3 (-transform.localScale.x, transform.localScale.y, 1f);
		} else { 
			direcao = Vector2.right;
			transform.localScale = new Vector3 (transform.localScale.x, transform.localScale.y, 1f);
		}
	}

	// Update is called once per frame
	void Update ()
	{

		transform.Translate (direcao * velocidade * Time.deltaTime);

	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Porta") {
			Application.LoadLevel (Application.loadedLevel + 1);
			// Debug.Log ("Chegamos");
		}
	}
}
