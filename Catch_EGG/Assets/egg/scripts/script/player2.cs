using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class player2 : MonoBehaviour
{

    [SerializeField]
    int Speed;

    public int score = 0;

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

        }



    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(1, 0, 0) * Speed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1, 0, 0) * Speed * Time.deltaTime);
        }


        float currentXPos = transform.position.x;
        currentXPos = Mathf.Clamp(currentXPos, -7.41f, 7.41f);
        transform.position = new Vector3(currentXPos, transform.position.y, transform.position.z);



        if (countegg == 10)
        {
            score += 5;
            countegg = 0;
            Debug.Log(" egg cont 5 point work");


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


    }



}






















