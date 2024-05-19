using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   public static LevelManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public enum SceneName
    {
        Level1 =1,
        Level2 = 2,
    }

    public SceneName Map;

    private void Start()
    {
        Map = SceneName.Level1;
    }

    public void NextLevel()
    {
        Map = (SceneName)(((int)Map) + 1);
        if (SceneManager.GetSceneByName(Map.ToString()) != null)
        {
            Debug.Log("Loaddddddddddddddddddddddddddddddddddddddddddddddddd");
            SceneManager.LoadScene(Map.ToString());
        }
    }
}
