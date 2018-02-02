using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {
    public ObjectPool Pool;
    public GameObject Prefab;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            var obj = Pool.GetObject(); //Instantiate(Prefab);
            obj.GetComponent<Projectile>().Pool = Pool;
            obj.transform.position = transform.position;

        }
    }

}
