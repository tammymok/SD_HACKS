using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    public int startingHealth = 100;
    public static int healthBarLength = 100;
    private int JELLY_HEALTH_POINTS = 8;
    public static int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public float flashSpeed = 5f;
    public Color flashColor = new Color(255, 0, 0);
    private float timeCount = 0;

    Animator anim;
    bool isDead;

    public Slider mainSlider;

    
    public GameObject EndCanvas;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        currentHealth = startingHealth;
	}

   
    public void eatJelly()
    {
            
            currentHealth += 8;
            if (currentHealth > healthBarLength){
                currentHealth = healthBarLength;
            }
    }

    public void eatTrash()
    {
            if (healthBarLength == startingHealth){
                Debug.Log("first trash eaten");
                currentHealth -= 34;
                mainSlider.maxValue = healthBarLength;
            }else{
                Debug.Log("ate trash");
                currentHealth -= 33;
                mainSlider.maxValue = healthBarLength;
            }

            if (currentHealth > healthBarLength){
                currentHealth = healthBarLength;
                mainSlider.value = currentHealth;
            }

    }
	// Update is called once per frame
	void Update () {
        timeCount += Time.deltaTime;

        if(timeCount >= 1) {
            currentHealth--;

            mainSlider.value = currentHealth;

            timeCount--;
        }

        if (currentHealth <= 0)
        {
            Spawner.setIsSpawning(false);
            EndCanvas.SetActive(true);
            mainSlider.gameObject.SetActive(false); // hide slider
            Debug.Log("DIEEEE"); //die make it appear later
        }
	}
}
