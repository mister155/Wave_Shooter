using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_Spawning : MonoBehaviour {

    public GameObject Enemy;
    public Transform[] spawnPoints;
    public float spawnTime = 3f;

	void Start () {
        Invoke("Spawn", spawnTime);
	}
	
    void Spawn()
    {
        float randomTime = Random.Range(0.5f, 3.0f);
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(Enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        Invoke("Spawn", randomTime);
    }

	void Update () {
        if (GameObject.FindWithTag("Player") == null)
        {
            Destroy(this);
        }
    }
}
