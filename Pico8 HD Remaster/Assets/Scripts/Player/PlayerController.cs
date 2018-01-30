using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    public float velocity;
    public Rigidbody2D rb;
    //public Component playertransform = 
	// Use this for initialization
	void Start () {
        velocity = 1f;
        speed = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        float inputHorizontal = Input.GetAxis("Horizonatal");
        speed = inputHorizontal * velocity * Time.deltaTime;

        PlayerMovement();
    }

    public void PlayerMovement()
    {
        transform.position = new Vector3(speed, 0, 0);
    }
    
}
