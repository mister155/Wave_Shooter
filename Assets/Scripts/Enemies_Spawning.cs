using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies_Spawning : MonoBehaviour {

    public GameObject Enemy;
    public Transform[] spawnPoints;
    public float spawnTime = 3f;

	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(Enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

    }
	// Update is called once per frame
	void Update () {
        if (GameObject.FindWithTag("Player") == null)
        {
            Destroy(this);
        }
    }
}
