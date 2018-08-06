using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvement : MonoBehaviour {
    public Animator gg;
    public GameObject player;
    public float speed = 150;
    private Vector2 velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
         
        GetComponent<Rigidbody2D>().velocity = Vector2.right * x * speed;
        GetComponent<Rigidbody2D>().velocity =  Vector2.left * x * speed;
        if (GetComponent<Rigidbody2D>().velocity == Vector2.zero)
        {
            gg.SetBool("moving", false); 
        }
        else gg.SetBool("moving", true);
    }
}
