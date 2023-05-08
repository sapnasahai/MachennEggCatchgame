using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{

    public static ScoreManager instance;

    //public TMP_Text scoreText;
    public Player player_script;
    public TMP_Text text;
    public TMP_Text highscoreText;
    //public TMP_Text gameOverScoreText;



    public int highscore;


    private void Awake()
    {
        instance = this;

        highscore = PlayerPrefs.GetInt("HighScore");
        highscoreText.text = highscore.ToString();
    }


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        UpdatedHighScore();
    }


    public void UpdatedHighScore()  
    {
        if (player_script.score > highscore)
        {
            highscore = player_script.score;

            highscoreText.text = highscore.ToString();
            PlayerPrefs.SetInt("HighScore", highscore);

        }
            
    }


    public void Resetscore()
    {
        player_script.score = 0;
        text.text = player_script.score.ToString();
        //gameOverScoreText.text = player_script.score.ToString();
    }

}
