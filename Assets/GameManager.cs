using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int Score { get; private set; }
    public float StartTime { get; private set; }
    public static int totalScore = 0;
    private int left = 10;

    private void Awake()
    {
        Instance = this;
        Score = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore(int pt) 
    {
        Score += pt;
        left--;
        if (left == 0) 
        {
            GameEnd();
        }
    }

    public void GameEnd() 
    {
        totalScore = Score + (int)((60 - Time.time + StartTime) * 100);

        SceneManager.LoadScene("End");
    }
}
