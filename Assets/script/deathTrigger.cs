﻿using UnityEngine;
using System.Collections;

public class deathTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		print (other.name);
		Destroy(other.gameObject);
		if(this.name == "Goal"){
			gameMaster.isWon=true;
			//Application.LoadLevel("002");
		}
	}
}
