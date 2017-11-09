using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class move : MonoBehaviour {

    private Rigidbody player;
    public float walkSpeed = 7f;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        Vector3 targetVelocity = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
        player.velocity = targetVelocity * walkSpeed;

        //always keep straight up?
        this.transform.eulerAngles = new Vector3(0, 0, 0);
        this.transform.position = new Vector3(this.transform.position.x, 0, this.transform.position.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))    //if player collided with an object that has a wall tag then set the velocity to 0;
        {
            player.velocity = Vector3.zero;
        }
    }
}
