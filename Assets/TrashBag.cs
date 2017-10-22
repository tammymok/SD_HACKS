using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TrashBag : MonoBehaviour {
    public Vector3 velocity;
    bool everyOtherJelly = false;

    //Use these Vectors for moving Rigidbody components


    // Use this for initialization
    void Start()
    {
        if (everyOtherJelly == false) {
            velocity = velocityJellyNTrash.randomVelocity();
        }
        else{
            velocity = new Vector3(0, 0, 1);
        }
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
