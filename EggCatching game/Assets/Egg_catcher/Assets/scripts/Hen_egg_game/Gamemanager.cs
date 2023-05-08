using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;

    int score = 0;

    int MaxsValue = 10;

    public Text scoretext;

    public Slider livesSlider;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Increamentscore()
    {
        score++;
        scoretext.text = score.ToString();
    }
    public void Decrementlives()
    {
        //MaxsValue--;
        livesSlider.value = livesSlider.value-1;
        if (livesSlider.value > 1)
        {
            print("gameover");
            // print(lives);
           
        }
    }
    public void Incrementlives()
    {
        //MaxsValue--;
        livesSlider.value = livesSlider.value + 1;
    }
    public void Boost_score()
    {
        score = score + 2;
        scoretext.text = score.ToString();
    }

}
