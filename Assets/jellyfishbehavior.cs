using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class jellyfishbehavior : MonoBehaviour {
    Vector3 m_StartPosition, m_StartForce;
    Rigidbody m_Rigidbody;
    //Use Enum for easy switching between direction states
    MoveDirection m_MoveDirection;

    //Use these Vectors for moving Rigidbody components
    Vector3 m_ResetVector;
    Vector3 m_UpVector;
    Vector3 m_RightVector;
    const float speed = 5.0f;

    // Use this for initialization
    void Start () {

        //You get the Rigidbody component attached to the GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //This starts with the Rigidbody not moving in any direction at all
        m_MoveDirection = MoveDirection.None;

        //These are the GameObject’s starting position and Rigidbody position
        m_StartPosition = RandomPosition.getRandomPosition();//transform.position;
        m_StartForce = m_Rigidbody.transform.position;

        //This Vector is set to 1 in the y axis (for moving upwards)
        m_UpVector = Vector3.up;
        //This Vector is set to 1 in the x axis (for moving in the right direction)
        m_RightVector = Vector3.right;
        //This Vector is zeroed out for when the Rigidbody should not move

        m_ResetVector = Vector3.zero;
    }
	
    public Vector3 setJellyfishStartingPosition(Vector3 startingPosition)
    {
        m_StartPosition = startingPosition;
    }
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name.Equals("BattleZone")) {
            DestroyObject(this);
        }
    }
}
