using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Death : MonoBehaviour {

    public GameObject Player;
    public GameObject Blood;
    Player_Movement movement;
    Shooter shoot;
    bool isDead = false;


	void Start()
    {
        movement = GetComponent<Player_Movement>();
        shoot = GetComponent<Shooter>();
        
    }
	

	void Update () {
        Blood.transform.position = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;

        movement.enabled = false;
        shoot.enabled = false;


        Destroy(gameObject);

        Instantiate(Blood);

        


        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Zombie");
        foreach (GameObject go in gameObjectArray)
        {
            go.SetActive(false);
        }

    }
}
