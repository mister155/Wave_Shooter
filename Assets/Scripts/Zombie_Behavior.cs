using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Behavior : MonoBehaviour {


    private Transform Target;
    public float Speed = 2.0f;




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

         Target = GameObject.FindWithTag("Player").transform;
         transform.right = Target.position - transform.position;
         transform.position += transform.right * Speed * Time.deltaTime;

    }
}
