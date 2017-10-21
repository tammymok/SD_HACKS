using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [SerializeField] private GameObject Jellyfish;
    [SerializeField] private GameObject Trashbag;
    public int difficultyJelly = 1;
    public int difficultyTrash = 1;
    private float timeCount = 0;
    private int difficultyUpdated = 0;
    // Use this for initialization
    void Start() {
    }
	
	// Update is called once per frame
	void Update () {
        timeCount += Time.deltaTime;
        
        if (timeCount > 5) { 
            RandomPosition pos = this.gameObject.GetComponent<RandomPosition>();
            for (int i = difficultyJelly; i > 0; i--) {
                Vector3 randomPosition = pos.getRandomPosition();
                Instantiate(Jellyfish, randomPosition, Quaternion.identity);
            }
            for (int i = difficultyTrash; i > 0; i--) {
                Vector3 randomPosition = pos.getRandomPosition();
                Instantiate(Trashbag, randomPosition, Quaternion.identity);
                /*               GameObject trash = Instantiate(Trashbag, randomPosition, Quaternion.identity);
                               TrashBag garbage = trash.GetComponent<TrashBag>();
                               garbage.setTrashStartingPosition(randomPosition);*/
            }
            timeCount -= 5;

            difficultyUpdated++;
            if (difficultyUpdated % 7 == 0)
            {
                difficultyJelly++;
            }
            if (difficultyUpdated % 5 == 0)
            {
                difficultyTrash++;
            }
        }

		
	}



}
