using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private bool gameOver = false;
    private float score = 0.0f;

    private static float highScore = 0.0f;
    private static bool hasSaved = false;

    public float pointsPerUnitTravelled = 1.0f;
    public float gameSpeed = 10.0f;

	// Use this for initialization
	void Start ()
    {
        instance = this;
        LoadHighScore();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOver = true;
            if (!hasSaved)
            {
                SaveHighScore();
                hasSaved = true;
            }
        }

        if (gameOver)
        {
            if (Input.anyKeyDown)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }

        else
        {
            score += pointsPerUnitTravelled * gameSpeed * Time.deltaTime;
            if (score > highScore)
            {
                highScore = score;
                hasSaved = false;
            }
        }
	}

    void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", (int)highScore);
        PlayerPrefs.Save();
    }

    void LoadHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
    }

    void OnGUI()
    {
        int currentScore = (int)score * 10;
        int currentHighScore = (int)highScore * 10;
        GUILayout.Label("Score: " + currentScore.ToString());
        GUILayout.Label("High Score: " + currentHighScore.ToString());

        if (gameOver == true)
        {
            GUILayout.Label("Game Over. Press any key to reset.");
        }
    }
}
