using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogWheelSpawner : MonoBehaviour
{
    public GameObject cogwheelPrefab;
    public float spawnFrequence = 3;

    void Start()
    {
        InvokeRepeating("Spawn", 0, spawnFrequence);
    }

    void Spawn()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.y = Random.Range(-2f, 2f); 
        Instantiate(cogwheelPrefab, spawnPosition, Quaternion.identity);
    }
}
