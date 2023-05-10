using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class  BirdController2 : MonoBehaviour
{

    public float speed = 2f; // The speed at which the bird moves

    private Vector3 dir = Vector3.left;


    private Animator animator; // The animator component for the bird


    [SerializeField] GameObject Bird;

    [SerializeField] private AudioSource pop_sound_Eggs;


    public GameObject Egg_prefab;
    public GameObject golden_prefab;
    public GameObject special_prefab;


    public float interval1 = 5;
    public float interval2 = 5;
    public float interval3 = 5;
    float timer1;
    float timer2;
    float timer3;

    private Rigidbody rb;


    void Start()
    {

        rb = GetComponent<Rigidbody>();

        // Get the animator component for the bird
        animator = GetComponent<Animator>();



        //InvokeRepeating("SpawnBird", 9.5f, 1);


    }

    /*void SpawnBird()
    {
        float tempPosy = UnityEngine.Random.Range(4.2f, 0.8f);
        float tempPosx = UnityEngine.Random.Range(10f, 10f);
        Instantiate(Bird, new Vector3(tempPosx, tempPosy, 0), Quaternion.identity);
        //Instantiate(Bird, new Vector3(tempPosx, 3.16f, 0), Quaternion.identity);

    }*/


    void Update()
    {
        

       // transform.Translate(Vector2.right * speed * Time.deltaTime);

       /* if (transform.position.x > 10f)
        {
            //Destroy(gameObject);

        }*/

        transform.Translate(dir * speed * Time.deltaTime);

        if (transform.position.x <= -4)
        {
            dir = Vector3.right;
        }
        /*else if (transform.position.x >= 4)
        {
            dir = Vector3.left;
        }*/






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
    }

}




