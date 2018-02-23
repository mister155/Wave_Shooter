using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Damage : MonoBehaviour {

    public float healthPoints = 5.0f;
    public GameObject Blood;
    public Player_Death player_Death;

    private void Start()
    {
       player_Death = GetComponent<Player_Death>();
    }
    void OnCollisionEnter2D()
    {

        if (healthPoints <= 0)
        {
            gameObject.SetActive(false);
            Bleeding();
            player_Death.kills++;
        }
        else
        {
            healthPoints -= 1.0f;
        }
    }

    void Bleeding()
    {
        Blood.transform.position = transform.position;
        Blood.transform.rotation = transform.rotation;
        Instantiate(Blood);

    }
}
