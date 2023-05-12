using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class Player : MonoBehaviour
{

    [SerializeField]
    private float Speed = 10f;

    private float movementX;
    private Rigidbody2D myBody;
    private SpriteRenderer sr;

    private Animator player_anim;
    private string RUN_ANIMATION = "Run";
    private string happy_ANIMATION = "Happy";
    //private string sad_ANIMATION = "Sad";
    //private bool isGrounded = true;

    public int score;
    //public ScoreManager SM_script;
    

    public GameObject normal_egg;
    public GameObject golden_egg;

    public GameObject special_egg;

    public Ground script;

    public GameObject sparcals;

    public GameObject E1, E2, E3, E4, E5, E6, E7, E8, E9, E10; // egg count in basket
    public int Egglife = 10;
    public int countegg;

    [SerializeField] private AudioSource catch_sound_eggs;
    [SerializeField] private AudioSource lifeloss_sound;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Egg")
        {

            score += 1;
            countegg += 1;
            catch_sound_eggs.Play();
            Destroy(collision.gameObject);
            sparcals.SetActive(false);

            /*if ( isGrounded)
            {
                //isGrounded = false;
                player_anim.SetTrigger(happy_ANIMATION);
                //Debug.Log("happy animation work");
                
            }*/

            

            if (countegg == 0)
            {
                E1.SetActive(false);
                E2.SetActive(false);
                E3.SetActive(false);
                E4.SetActive(false);
                E5.SetActive(false);
                E6.SetActive(false);
                E7.SetActive(false);
                E8.SetActive(false);
                E9.SetActive(false);
                E10.SetActive(false);

            }

            if (countegg == 1)
            {
                E1.SetActive(true);
                Debug.Log("eggnormal work in basket");
            }

            if (countegg == 2)
            {
                E2.SetActive(true);
            }
            if (countegg == 3)
            {
                E3.SetActive(true);
            }
            if (countegg == 4)
            {
                E4.SetActive(true);
            }
            if (countegg == 5)
            {
                E5.SetActive(true);
            }
            if (countegg == 6)
            {
                E6.SetActive(true);
            }
            if (countegg == 7)
            {
                E7.SetActive(true);
            }
            if (countegg == 8)
            {
                E8.SetActive(true);
            }
            if (countegg == 9)
            {
                E9.SetActive(true);
            }





            if (countegg == 10)
            {
                E10.SetActive(true);
            }


        }


        if (collision.tag == "golden_egg")
        {
            score += 20;
            catch_sound_eggs.Play();
            Destroy(collision.gameObject);
            sparcals.SetActive(true);
            Debug.Log("godlen work");



        }

        if (collision.tag == "special_egg")
        {
            score += 5;
            //script.EndgameLife += 1;
            catch_sound_eggs.Play();
            Destroy(collision.gameObject);
            sparcals.SetActive(false);
            Debug.Log("special work");
        }

        if (collision.tag == "special_egg") // life will only increse when life is less than 6 (actual life)
        {
            if (script.EndgameLife < 6)
            {
                script.EndgameLife += 1;
                Debug.Log("life increse");
            }



        }

        if (collision.tag == "Bomb")
        {
            script.EndgameLife -= 1;
            lifeloss_sound.Play();
            //Destroy(collision.gameObject, 0.3f);
            Debug.Log("bomb work life decrese");


        }


    }


    



    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        player_anim = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
        float currentXPos = transform.position.x;
        currentXPos = Mathf.Clamp(currentXPos, -7.10f, 7.10f);
        transform.position = new Vector3(currentXPos, transform.position.y, transform.position.z);
        
        

        if (countegg == 10)
        {
            score += 5;
            countegg = 0;
            Debug.Log(" egg cont 5 point work");

            //player_anim.SetTrigger(happy_ANIMATION);
            PlayerHappy();

            E1.SetActive(false);
            E2.SetActive(false);
            E3.SetActive(false);
            E4.SetActive(false);
            E5.SetActive(false);
            E6.SetActive(false);
            E7.SetActive(false);
            E8.SetActive(false);
            E9.SetActive(false);
            E10.SetActive(false);



        }


        //SM_script.highscore = score;

        PlayerMovementOnKeyboard();
        AnimatePlayer();

    }

    void PlayerMovementOnKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");  // -1 (left), 0  ,1 (right)

        transform.position += new Vector3(movementX, 0f, 0f) * Speed * Time.deltaTime;
    }

    void AnimatePlayer()
    {
        // going to move right
        if(movementX > 0)
        {
            player_anim.SetBool(RUN_ANIMATION, true);
            sr.flipX = false;
        }
        else if(movementX < 0) // going to move left
        {
            player_anim.SetBool(RUN_ANIMATION, true);
            sr.flipX = true;
        }
        else
        {
            player_anim.SetBool(RUN_ANIMATION, false);
        }
    }


    void PlayerHappy()
    {

        player_anim.SetTrigger(happy_ANIMATION);
        
    }


    



}






















