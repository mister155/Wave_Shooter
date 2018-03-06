using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Behavior : MonoBehaviour {

    public AudioSource zombieMoan;
    private Transform _Target;
    private float _Speed = 2.0f;

    void Start () {
        StartCoroutine(Moan());
        _Speed = Random.Range(1.0f, 5.0f);
        Moan();
    }

	void Update () {
         _Target = GameObject.FindWithTag("Player").transform;
         transform.right = _Target.position - transform.position;
         transform.position += transform.right * _Speed * Time.deltaTime;
    }

    IEnumerator Moan()
    {
        float randomTime = Random.Range(1.0f, 5.0f);
        yield return new WaitForSeconds(randomTime);
        zombieMoan.Play();
        StartCoroutine(Moan());

    }
}
