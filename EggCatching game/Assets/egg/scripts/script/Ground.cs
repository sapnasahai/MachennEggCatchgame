using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ground : MonoBehaviour
{

    public int EndgameLife = 6;

    public GameObject L1, L2, L3, L4, L5, L6;  //player life count

    //public GameObject gameOver;
    public GameObject Restart_panel;
    public GameObject LeaderBoard_Panel;
    //public GameObject RestartButton;



    public GameObject player;
    // public GameObject Bird;


    [SerializeField] private AudioSource lifeloss_sound;
    [SerializeField] private AudioSource explosion_sound;

    //private Animator player_anim;
    //private string sad_ANIMATION = "Sad";

    //public GameManager game_manager;
    //public GameManager2 game_manager2;
    //public Bombmanger bm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Egg")
        {
            EndgameLife -= 1;
            lifeloss_sound.Play();
            Destroy(collision.gameObject,8f);

            //player_anim.SetTrigger(sad_ANIMATION);
            //egg = broken_egg;
            //broken_egg.SetActive(true);
            //Destroy(broken_egg, 5);


        }
        if (collision.tag == "golden_egg")
        {
            EndgameLife -= 1;
            lifeloss_sound.Play();
            Destroy(collision.gameObject);

            

        }
        if (collision.tag == "special_egg")
        {
            EndgameLife -= 1;
            lifeloss_sound.Play();
            Destroy(collision.gameObject);



        }





        if (collision.tag == "Bomb")
        {
            //EndgameLife -= 1;
            explosion_sound.Play();
            Destroy(collision.gameObject,0.3f);

        }

    }


    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    
        switch (EndgameLife)
        {
            case 0:
                L1.SetActive(false);
                L2.SetActive(false);
                L3.SetActive(false);
                L4.SetActive(false);
                L5.SetActive(false);
                L6.SetActive(false);
                //gameOver.SetActive(true);
                //Time.timeScale = 0f;
                Restart_panel.SetActive(true);
                //RestartButton.SetActive(true);
                //game_manager.gm1= false;
                //game_manager2.gm2 = false;
                


                break;

            case 1:
                L1.SetActive(true);
                L2.SetActive(false);
                L3.SetActive(false);
                L4.SetActive(false);
                L5.SetActive(false);
                L6.SetActive(false);
                break;

            case 2:
                L1.SetActive(true);
                L2.SetActive(true);
                L3.SetActive(false);
                L4.SetActive(false);
                L5.SetActive(false);
                L6.SetActive(false);
                break;

            case 3:
                L1.SetActive(true);
                L2.SetActive(true);
                L3.SetActive(true);
                L4.SetActive(false);
                L5.SetActive(false);
                L6.SetActive(false);
                break;

            case 4:
                L1.SetActive(true);
                L2.SetActive(true);
                L3.SetActive(true);
                L4.SetActive(true);
                L5.SetActive(false);
                L6.SetActive(false);
                break;

            case 5:
                L1.SetActive(true);
                L2.SetActive(true);
                L3.SetActive(true);
                L4.SetActive(true);
                L5.SetActive(true);
                L6.SetActive(false);
                break;

            case 6:
                L1.SetActive(true);
                L2.SetActive(true);
                L3.SetActive(true);
                L4.SetActive(true);
                L5.SetActive(true);
                L6.SetActive(true);
                break;

            default:
                L1.SetActive(false);
                L2.SetActive(false);
                L3.SetActive(false);
                L4.SetActive(false);
                L5.SetActive(false);
                L6.SetActive(false);
                break;




        }


           












        if (EndgameLife <= 0)
        {
          //Debug.Log("EndGame");
          player.SetActive(false);

          //Bird.SetActive(false);



            //Time.timeScale = 0f;
        }
        else
        {
            //Time.timeScale = 1f;
        }



    }


   
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Restart is working");

        //Time.timeScale = 1f;
        ScoreManager.instance.Resetscore();
    }

    public void LeaderBoard()
    {
        LeaderBoard_Panel.SetActive(true);
    }

}
