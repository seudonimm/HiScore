using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveTxt : MonoBehaviour {

    private string fileName = "PREVENT-NPC-RELATEDCRASH.txt";
    private string filePath;
    public string txt;

    // Use this for initialization
    void Start () {

        filePath = Application.dataPath + "/" + fileName; /*Path.Combine(Application.dataPath, fileName);*/

        
        int i = PlayerPrefs.GetInt("end", 0);
        if (i == 0 || i == 3)
        {
            Debug.Log("AHHHHHHHHHHHHHHHHH");
        }
        else if (i == 1 && !File.Exists(filePath))
        {
            File.WriteAllText(filePath, "**CHANGE OFF TO ON** \n\n");

            string content = "ANTI-SHUTDOWN FUNCTION: OFF";

            ////StreamWriter writer = new StreamWriter(filePath, true);
            ////writer.WriteLine("ANTI-SHUTDOWN FUNCTION: OFF");
            ////writer.Close();

            File.AppendAllText(filePath, content);

        }
        else if (File.Exists(filePath))
        {
            if (ReadString() == 2 && i != 2)
            {
                PlayerPrefs.SetInt("end", 2);
            }
        }
    }

    int ReadString()
    {
        filePath = Application.dataPath + "/" + fileName; /*Path.Combine(Application.dataPath, fileName);*/

        txt = File.ReadAllText(filePath);

        //filePath = Path.Combine(Application.dataPath, fileName);

        ////Read the text from directly from the test.txt file
        //StreamReader reader = new StreamReader(filePath);
        //txt = reader.ReadToEnd();
        //Debug.Log(reader.ReadToEnd());
        //reader.Close();


        if (txt == "**CHANGE OFF TO ON** \n\n" + "ANTI-SHUTDOWN FUNCTION: ON")
        {
            return 2;
        }
        else
        {
            return 0;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
