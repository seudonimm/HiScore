//using System.Collections;
//using System.Collections.Generic;
//using System.IO;
//using UnityEngine;

//public class Saving : MonoBehaviour {
//    private string fileName = "ANTICRASH.txt";
//    private string filePath;

//    public GameObject g;

//    private static Saving _instance;
//    public Saving Instance
//    {
//        get { return _instance; }
//    }

//    GameData gameData;

//	// Use this for initialization
//	private void Awake () {
//        DontDestroyOnLoad(gameObject);

//        if(_instance == null)
//        {

//            _instance = g.AddComponent<Saving>();
//        }
        
//        if(gameData == null)
//        {
//            gameData = g.AddComponent<GameData>();
//        }

//        filePath = Path.Combine(Application.dataPath, fileName);
//	}

//    private void Start()
//    {
//        int i = PlayerPrefs.GetInt("end", 0);
//        LoadGameData();
//        if (gameData.active == "ON")
//        {
//            PlayerPrefs.SetInt("end", 2);
//        }
//        else if (i == 1)
//        {
//            gameData.function = "ANTI-SHUTDOWN FUNCTION\n";
//            gameData.active = "OFF";
//            SaveGameData();
//        }

//    }

//    void SaveGameData(){
//        string json = JsonUtility.ToJson(gameData);

//        if (!File.Exists(filePath))
//        {
//            File.Create(filePath).Dispose();
//        }

//        File.WriteAllText(filePath, json);
//    }

//    void LoadGameData(){
//        string json;

//        if (File.Exists(filePath))
//        {
//            json = File.ReadAllText(filePath);
//            gameData = JsonUtility.FromJson<GameData>(json);
//        }
//        else
//        {
//            Debug.Log("File is missing" + filePath);
            
//        }

//    }
//    // Update is called once per frame
//    void Update () {
		
//	}
//}
////public class GameData
////{
////    public string function;
////    public string active;
////}
