using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameConTroller : MonoBehaviour
{
    public static GameConTroller Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private bool isFinish;
    private int score = 0;

    private void Start()
    {
        Time.timeScale = 1;
        UIManager.Instance.SetScore("Score: " + score);
    }

    private void Update()
    {
        if (isFinish)
        {
            UIManager.Instance.ShowFinishCanvas(true);
            Time.timeScale = 0;
        }
    }

    public void SetScore(int score)
    {
        this.score = score;
    }

    public int GetScore()
    {
        return score;
    }

    public void SetIsFinish(bool isFinish)
    {
        this.isFinish = isFinish;
    }

    public bool GetIsFinish()
    {
        return isFinish;
    }

    public void HighScore()
    {
        score++;
        UIManager.Instance.SetScore("Score: " + score);
    }

    public void Replay()
    {
        Time.timeScale = 1;
        score = 0;
        isFinish = false;
        UIManager.Instance.SetScore("Score: " + score);
        UIManager.Instance.ShowFinishCanvas(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextLever()
    {
        Time.timeScale = 1;
        LevelManager.instance.NextLevel();
    }
}
