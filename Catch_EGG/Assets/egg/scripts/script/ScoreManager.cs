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

    
     public int highscore = 0;


    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highsscore", 0);
        text.text = player_script.score.ToString();
        highscoreText.text =  highscore.ToString();
    }

    


    public void AddPoint()  
    {
        if (highscore < player_script.score)
            PlayerPrefs.SetInt("Highscore", player_script.score);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
