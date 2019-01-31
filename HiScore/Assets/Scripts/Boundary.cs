using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boundary : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
	}

    public void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        SceneManager.LoadScene("Title");
    }
}
