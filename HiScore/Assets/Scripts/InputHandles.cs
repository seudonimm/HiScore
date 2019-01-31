using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandles : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InputTxt(string init)
    {
        PlayerPrefs.SetInt("end", 3);

        PlayerPrefs.SetString("hiscore", init);

        Application.Quit();
    }

}
