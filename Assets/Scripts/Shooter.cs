using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
//    public ObjectPool Pool;
    public GameObject Prefab;
    public AudioSource sound;

    void Update()
    {
        Prefab.transform.position = transform.position;

        if (Input.GetMouseButtonDown(0))
        {
            sound.Play();
              Instantiate(Prefab);

        }
    }

}
