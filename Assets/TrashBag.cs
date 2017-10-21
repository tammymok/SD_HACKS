using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class TrashBag : MonoBehaviour {
    Vector3 velocity;


    //Use these Vectors for moving Rigidbody components


    // Use this for initialization
    void Start()
    {
        velocity = new Vector3(0, 0, 1);
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
            DestroyObject(this);
        }
    }
}
