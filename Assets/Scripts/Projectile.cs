using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {
    public ObjectPool Pool;
    public float Life = 1.0f;
    public GameObject bullet;
    public float Speed = 10.0f;


    // Update is called once per frame
    void Update () {

        Life -= Time.deltaTime;
        transform.position += transform.up * Speed*Time.deltaTime;

        //Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //transform.rotation = Quaternion.Euler(0, 0, angle - 90);

        Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
        Vector2 direction = target - myPos;
        direction.Normalize();
        Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
        GameObject projectile = (GameObject)Instantiate(bullet, myPos, rotation);
        projectile.Rigidbody2D.velocity = direction * Speed;


        if (Life <0.0f)
        {
            Pool.ReleaseObject(gameObject);
            //Destroy(gameObject);
        }
	}
}
