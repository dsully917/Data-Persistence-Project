using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    public static GameDataManager gameDataManager;

    private void Awake()
    {
        if (gameDataManager != null)
        {
            Destroy(gameObject);
            return;
        }

        gameDataManager = this;
        DontDestroyOnLoad(gameObject);
    }
}
