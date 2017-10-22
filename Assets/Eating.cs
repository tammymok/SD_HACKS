using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eating : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter(Collider other)
    {
        TrashBag trash = other.gameObject.GetComponentInParent<TrashBag>();
        jellyfishbehavior jelly = other.gameObject.GetComponentInParent<jellyfishbehavior>();
        if(trash != null){
            Debug.Log("eat trash not null");
            this.gameObject.GetComponent<PlayerHealth>().eatTrash();
        } else if(jelly != null)
        {
            Debug.Log("ate jelly");
            this.gameObject.GetComponent<PlayerHealth>().eatJelly();
        }
        Destroy(other.gameObject);
    }
}
