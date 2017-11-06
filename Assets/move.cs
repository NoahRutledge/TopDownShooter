using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class move : MonoBehaviour {

    private Rigidbody player;
    public float walkSpeed = 4f;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        Vector2 targetVelocity = new Vector3(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody>().velocity = targetVelocity * walkSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))    //if player collided with an object that has a wall tag then set the velocity to 0;
        {
            player.velocity = Vector3.zero;
        }
    }
}
