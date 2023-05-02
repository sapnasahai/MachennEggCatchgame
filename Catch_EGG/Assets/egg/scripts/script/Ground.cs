using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    public int EndgameLife = 6;

    public GameObject L1, L2, L3, L4, L5, L6;  //player life count

    public GameObject gameOver;
    //public GameObject backtoMenu;


    public GameObject player;
    // public GameObject Bird;


    [SerializeField] private AudioSource lifeloss_sound;
    [SerializeField] private AudioSource explosion_sound;



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
    void Update()
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
                gameOver.SetActive(true);
                //game_manager.gm1= false;
                //game_manager2.gm2 = false;
                //bm.bm1 = false;


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















        if(EndgameLife <= 0)
        {
          //Debug.Log("EndGame");
          player.SetActive(false);

          //Bird.SetActive(false);



            // Time.timeScale = 0f;
        }



    }


   


}
