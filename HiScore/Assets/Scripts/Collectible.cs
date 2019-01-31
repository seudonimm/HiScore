using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour {

    public GameObject g;

    

	// Use this for initialization
	void Start () {
    
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnTriggerEnter2D(Collider2D col)
    {
       
        Destroy(g);

        GameObject player = GameObject.Find("Player");
        GameManager gm = player.GetComponent<GameManager>();
        gm.score += 1f;

        
        
    }
}
