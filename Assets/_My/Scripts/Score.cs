using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score Instance;
    [SerializeField]
    public TextMeshProUGUI ScoreText;
    private int score = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateScore()
    {
        score += 10;
    }

    public void Update()
    {
        ScoreText.text = score.ToString();
    }

}
