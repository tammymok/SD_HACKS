using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [SerializeField] private GameObject Jellyfish;
    [SerializeField] private GameObject Trashbag;
    [SerializeField] private GameObject SpawnZone;
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

            
            for (int i = difficultyJelly; i > 0; i--) {
                Instantiate(Jellyfish, getRandomPositionInSpawnZone(), Quaternion.identity);
            }
            for (int i = difficultyTrash; i > 0; i--) {
                Instantiate(Trashbag, getRandomPositionInSpawnZone(), Quaternion.identity);
            }
            timeCount -= 5;

            difficultyUpdated++;
            if (difficultyUpdated % 4 == 0)
            {
                difficultyJelly++;
            }
            if (difficultyUpdated % 3 == 0)
            {
                difficultyTrash++;
            }
        }

		
	}

    Vector3 getRandomPositionInSpawnZone()
    {
        Vector3 randomPosition = SpawnZone.transform.position;
        Vector3 zoneScale = SpawnZone.transform.lossyScale;
        randomPosition.x += zoneScale.x * (Random.value - 0.5f);
        randomPosition.y += zoneScale.y * (Random.value - 0.5f);
        randomPosition.z += zoneScale.z * (Random.value - 0.5f);
        return randomPosition;
    }




}
