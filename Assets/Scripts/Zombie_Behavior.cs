using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Behavior : MonoBehaviour {


    private Transform Target;
    private float _Speed = 2.0f;

    void Start () {
        _Speed = Random.Range(1.0f, 5.0f);
    }

	void Update () {
         Target = GameObject.FindWithTag("Player").transform;
         transform.right = Target.position - transform.position;
         transform.position += transform.right * _Speed * Time.deltaTime;
    }
}
