using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Death : MonoBehaviour {

    public GameObject Player;
    public GameObject Blood;
    Player_Movement movement;
    Shooter shoot;
    public int kills = 0;

    void Start()
    {
        movement = GetComponent<Player_Movement>();
        shoot = GetComponent<Shooter>();
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
        //movement.enabled = false;
        //shoot.enabled = false;
        //Destroy(gameObject);
        //Blood.transform.position = transform.position;
        //Instantiate(Blood);

        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Zombie");
        foreach (GameObject go in gameObjectArray)
        {
            go.SetActive(false);
        }

        Application.LoadLevel("GameOverScene");
    }
}
