using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour {

    public float Life = 3.0f;
    public AudioSource deathSound;

    private void Start()
    {
        deathSound.Play();
    }
    void FixedUpdate () {

        Life -= Time.deltaTime;
        if (Life < 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
