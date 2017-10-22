using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TrashBag : MonoBehaviour {
    public Vector3 velocity = velocityJellyNTrash.randomVelocity();//new Vector3(0, 0, .5f);


    //Use these Vectors for moving Rigidbody components


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(velocity * Time.deltaTime);
        }

    public void OnTriggerExit(Collider collision)
    {
        Debug.Log("going into trigger exit, trash");
        if (collision.gameObject.name.Equals("BattleZone"))
        {
            Destroy(this.gameObject);
        }
    }
}
