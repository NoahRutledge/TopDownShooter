using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chasePlayer : MonoBehaviour {

    public Transform target;
    private Transform enemy;
    public float moveSpeed = 3.0f;

	// Use this for initialization
	void Start () {
        enemy = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
        float dx = target.position.x - enemy.position.x;
        float dz = target.position.z - enemy.position.z;

        int x, z;
        if(dx < 0.25 && dx > -0.25)
        {
            x = 0;
        }
        else
        {
            x = dx > 0 ? 1 : -1;
        }
        if(dz < 0.25 && dz > -0.25)
        {
            z = 0;
        }
        else
        {
            z = dz > 0 ? 1 : -1;
        }

        if(Mathf.Abs(dx) - 1.1 < 0 && Mathf.Abs(dz) - 1.1 < 0)
        {
            //set velocity to 0
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        else
        {
            Vector3 targetVelocity = new Vector3(x, 0, z);
            GetComponent<Rigidbody>().velocity = targetVelocity * moveSpeed;
        }
    }
}
