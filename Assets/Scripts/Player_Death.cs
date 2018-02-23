using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Death : MonoBehaviour {

    public GameObject Player;
    public GameObject Blood;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            Death();
        }
    }

    void Death()
    {
        Destroy(gameObject);

        GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag("Zombie");
        foreach (GameObject go in gameObjectArray)
        {
            go.SetActive(false);
        }

        Application.LoadLevel("GameOverScene");
    }
}
