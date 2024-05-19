using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject FinishCanvas;

    public void SetScore(string score)
    {
        if (scoreText)   scoreText.text = score;
    }

    public void ShowFinishCanvas(bool isFinish)
    {
        if(isFinish)
        {
            FinishCanvas.SetActive(isFinish);
        }
    }
}
