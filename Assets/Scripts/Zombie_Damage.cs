using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Damage : MonoBehaviour {

    public float healthPoints = 5.0f;
    public float Life = 3.0f;
    public GameObject Blood;
    public GameObject Zombie;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Blood.transform.position = transform.position;

    }

    void OnCollisionEnter2D()
    {

        if (healthPoints <= 0)
        {
            gameObject.SetActive(false);
            Bleeding();
        }
        else
        {
            healthPoints -= 1.0f;
        }
    }

    void Bleeding()
    {
        Instantiate(Blood);
        Life -= Time.deltaTime;
        if (Life < 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
