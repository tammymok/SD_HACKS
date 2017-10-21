using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{

    [SerializeField] private GameObject SpawnZone;
    private Vector3 randomPosition;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Vector3 getRandomPosition()
    {
        return randomPositionInSpawnZone();
    }

    Vector3 randomPositionInSpawnZone()
    {
        Vector3 randomPositionInSpawnZone = SpawnZone.transform.position;
        Vector3 zoneScale = SpawnZone.transform.lossyScale;
        randomPositionInSpawnZone.x += zoneScale.x * (Random.value - 0.5f);
        randomPositionInSpawnZone.y += zoneScale.y * (Random.value - 0.5f);
        randomPositionInSpawnZone.z += zoneScale.z * (Random.value - 0.5f);
        return randomPositionInSpawnZone;
    }
}
