﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float Life = 0.3f;
    public GameObject bullet;
    public float Speed = 10.0f;
 
    void Update () {

        Life -= Time.deltaTime;
        transform.position += transform.up * Speed*Time.deltaTime;

        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle - 90);

        if (Life <0.0f)
        {

            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Zombie")
        {
            Destroy(gameObject);
        }
    }
}
