using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Events3 : MonoBehaviour {

    public bool e1, e2, e3, e4, ahh;
    public bool n, y, crash;
    public bool e21, e22, e23, e24, e25, e26, e27, e28, e29, e30, e31;

    public Text pol;

    public int i = 0;

    // Use this for initialization
    void Start () {
        pol.text = "Unfortunately, now that theres no one here to man this game it will have to be shut down";

    }

    // Update is called once per frame
    void Update () {
        
        if (i == 0)
        {
            //pol.text = "Unfortunately, now that theres no one here to man this game it will have to be shut down";

            e21 = true;
            e22 = true;
            e23 = true;
            e24 = true;
            e25 = true;
            e26 = true;
            e27 = true;
            e28 = true;
            e29 = false;
            e30 = false;
            e31 = false;

            i = 1;
        }
        int finish = PlayerPrefs.GetInt("finish", 0);

        GameObject player = GameObject.Find("Player");
        GameManager gm = player.GetComponent<GameManager>();
        PlayerController pc = player.GetComponent<PlayerController>();
        GameObject camera = GameObject.Find("Main Camera");
        Boundary bd = camera.GetComponent<Boundary>();

        if (finish == 1)
        {
            pc.moveSpeed = 3;
            bd.speed = 3;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = GameObject.Find("Player");
        GameManager gm = player.GetComponent<GameManager>();
        PlayerController pc = player.GetComponent<PlayerController>();

        GameObject camera = GameObject.Find("Main Camera");
        Boundary bd = camera.GetComponent<Boundary>();

        if (e21 && e22 && e23 && e24 && e25 && e26 && e27 && e28 && !e29)
        {
            pol.text = "But before we do that what is your name: ";
            gm.speech.text = "";

            pc.moveSpeed = 0;
            bd.speed = 0;
            PlayerPrefs.SetInt("end", 3);

            e29 = true;
        }
        else if (e21 && e22 && e23 && e24 && e25 && e26 && e27 && e28 && e29 && !e30)
        {
            pol.text = "Thanks for your coooperation, Bye";
            gm.speech.text = "";

            pc.moveSpeed = 3;
            bd.speed = 3;

            e30 = true;
        }
        else if (e21 && e22 && e23 && e24 && e25 && e26 && e27 && e28 && e29 && e30 && !e31)
        {
            pol.text = "Thanks for your coooperation, Bye";
            gm.speech.text = "";

            e31 = true;

            PlayerPrefs.SetInt("end", 3);
            Application.Quit();
        }
    }
}
