using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public string highscoreHolder;
    public int highscore;
    public string username;

    public void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    [Serializable]
    public class SaveData
    {
        public int highscore;
        public string highscoreHolder;
    }
    public void Save(int highscore , string username)
    {
        SaveData data = new SaveData();
        data.highscore = highscore;
        data.highscoreHolder = username;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void Load()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            highscore = data.highscore;
            highscoreHolder = data.highscoreHolder;
        }
    }
}
