using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameDataManager : MonoBehaviour
{
    public static GameDataManager gameDataManager;

    public string currentUser;

    public string highUser;

    public int highScore;

    private void Awake()
    {
        if (gameDataManager != null)
        {
            Destroy(gameObject);
            return;
        }

        gameDataManager = this;
        DontDestroyOnLoad(gameObject);

        LoadHighScore();
    }

    [System.Serializable]
    class SaveData
    {
        public string highUser;
        public int highScore;
    }

    public void SaveHighScore()
    {
        SaveData data = new SaveData();
        data.highUser = highUser;
        data.highScore = highScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highUser = data.highUser;
            highScore = data.highScore;
        }
    }

    public void ResetHighScore()
    {
        highUser = "John Doe";
        highScore = 0;
        SaveHighScore();
    }
}
