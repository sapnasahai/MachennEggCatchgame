using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    public float speed = 2f; // The speed at which the bird moves

    


    private Animator animator; // The animator component for the bird


    [SerializeField] GameObject Bird;

    [SerializeField] private AudioSource pop_sound_Eggs ;


    public GameObject Egg_prefab;
    public GameObject golden_prefab;
    public GameObject special_prefab;


    public float interval1 = 5;
    public float interval2 = 5;
    public float interval3 = 5;
    float timer1;
    float timer2;
    float timer3;

    //public float outofBound = -12.0f;
    private Rigidbody rb;

   public Player player_script; // for score
    public TMP_Text text;
    public ScoreManager scoremanager_script;
    public TMP_Text gameOverScoreText;
    public TMP_Text gameOverHighScoreText;

    private SpriteRenderer sr;

    //public player2 player2_script;
    //public playerManager PM_script;
    public bool isMovingRight = true; // determines the initial direction of the bird

    void Start()
    {

        rb = GetComponent<Rigidbody>();

        // Get the animator component for the bird
        animator = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();

       
        

    }


    void Update()
    {


         timer1 += Time.deltaTime;
         if (timer1 >= interval1)
         {

             pop_sound_Eggs.Play();

             GameObject newObject = Instantiate(Egg_prefab, transform.position, Quaternion.identity);
             timer1 -= interval1;




         }



         timer2 += Time.deltaTime;
         if (timer2 >= interval2)
         {
             pop_sound_Eggs.Play();
             GameObject newObject = Instantiate(golden_prefab, transform.position, Quaternion.identity);
             timer2 -= interval2;




         }
         timer3 += Time.deltaTime;
         if (timer3 >= interval3)
         {
             pop_sound_Eggs.Play();
             GameObject newObject = Instantiate(special_prefab, transform.position, Quaternion.identity);
             timer3 -= interval3;



         }





        float direction = isMovingRight ? 1f : -1f; // determines the direction of the bird's movement based on the isMovingRight variable
        transform.position += Vector3.right * speed * Time.deltaTime * direction; // moves the bird to the right or left at a constant speed

        if (transform.position.x >= 9f && isMovingRight) // if the bird reaches the right boundary and is moving right, change direction
        {
            isMovingRight = false;
            sr.flipX = false;
        }
        else if (transform.position.x <= -9f && !isMovingRight) // if the bird reaches the left boundary and is moving left, change direction
        {
            isMovingRight = true;
            sr.flipX = true;
        }





        text.text =player_script.score.ToString();
        gameOverScoreText.text = player_script.score.ToString();
        gameOverHighScoreText.text = scoremanager_script.highscore.ToString();
        //scoremanager_script.UpdatedHighScore();

    }
}



