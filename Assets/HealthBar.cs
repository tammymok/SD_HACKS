using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    Text health;
	// Use this for initialization
	void Start () {
        health = this.gameObject.GetComponent<Text>();
        health.text = "Health: " + PlayerHealth.currentHealth + "/" + PlayerHealth.healthBarLength;
	}
	
	// Update is called once per frame
	void Update () {
        health.text = "Health: " + PlayerHealth.currentHealth + "/" + PlayerHealth.healthBarLength;
    }
}
