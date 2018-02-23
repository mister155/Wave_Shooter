using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : MonoBehaviour {

    public float Life = 3.0f;

	void FixedUpdate () {
        Life -= Time.deltaTime;
        if (Life < 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
