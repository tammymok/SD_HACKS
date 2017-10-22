using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocityJellyNTrash : MonoBehaviour {
    static double MIN_X_SPEED = 0.5;
    static bool isNegative = false;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }


    public static Vector3 randomVelocity()
    {
        Vector3 velocity = new Vector3 (0, 0, 0);
        velocity.z += (Random.value + (float)(MIN_X_SPEED));
        if (isNegative == true){
            velocity.y += Random.value / 5;
            velocity.x += Random.value / 5;
            isNegative = false;
        } else if(isNegative == false)
        {
            velocity.y -= Random.value / 5;
            velocity.x -= Random.value / 5;
            isNegative = true;
        }
        return velocity;
    }
}
