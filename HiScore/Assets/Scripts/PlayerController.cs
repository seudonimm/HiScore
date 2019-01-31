using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    public float jump;
   

    public bool onGround;

 
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);


        if(Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            rb.AddForce(transform.up * jump);
        }

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = false;
        }
    }

    //public void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.tag == "Coin")
    //    {
    //        Destroy(col.gameObject);
    //        score = +1;
    //    }
    //}
}
