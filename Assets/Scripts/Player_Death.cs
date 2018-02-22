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
        var anothercoll = new Dictionary<string, string> { {"string", "string"} };
        foreach(var anothercol in anothercoll)
        {
            var test = true;
        }
        movement = GetComponent<Player_Movement>();
        shoot = GetComponent<Shooter>();
    }
	

	void Update () {
		
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
        Blood.SetActive(true);


        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Zombie");
        foreach (GameObject go in gameObjectArray)
        {
            go.SetActive(false);
        }

    }
}
