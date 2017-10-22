using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocityJellyNTrash : MonoBehaviour {
    public static double MIN_X_SPEED = 0.5;
    public static bool isNegative = false;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }


    public static Vector3 randomVelocity()
    {
        Vector3 velocity = new Vector3 (0, 0, 0);
        velocity.z += (Random.Range(0.0f, 1.0f) + (float)(MIN_X_SPEED));
        if (isNegative == true){
            velocity.y += Random.Range(0.0f, 0.5f);
            velocity.x += Random.Range(0.0f, 0.5f);
            isNegative = false;
        } else if(isNegative == false)
        {
            velocity.y -= Random.Range(0.0f, 0.5f);
            velocity.x -= Random.Range(0.0f, 0.5f);
            isNegative = true;
        }
        return velocity;
    }
}
