using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chasePlayer : MonoBehaviour {

    public Transform target;
    private Transform enemy;
    public float moveSpeed = 3.0f;
    public float stopDistance = 1.5f;

	// Use this for initialization
	void Start () {
        enemy = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        float dx = target.position.x - enemy.position.x;
        float dz = target.position.z - enemy.position.z;

        int x, z;
        if(dx < stopDistance && dx > -stopDistance)
        {
            x = 0;
        }
        else
        {
            x = dx > 0 ? 1 : -1;
        }
        if(dz < stopDistance && dz > -stopDistance)
        {
            z = 0;
        }
        else
        {
            z = dz > 0 ? 1 : -1;
        }



        Vector3 targetVelocity = new Vector3(x, 0, z);
        GetComponent<Rigidbody>().velocity = targetVelocity * moveSpeed;

    }
}
