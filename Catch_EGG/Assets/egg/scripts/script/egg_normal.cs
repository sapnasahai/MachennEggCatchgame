using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class egg_normal : MonoBehaviour
{
    public GameObject objectTospawn;
    public float Interval = 5; // use for delay 
    float timer;


    //public static new Rigidbody2D rigidbody;

    //public Sprite Egg_broken;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= Interval)
        {
            Instantiate(objectTospawn);
            timer -= Interval;

        }
    }


   /* public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Boundary")
        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = Egg_broken;
            //Egg_broken.Physics2D.gravity = Vector2.zero;

        }*/










        /* if (transform.position.y >= -3)
       {
           transform.Translate(0f, -0.01f, 0f);
       }*/





    

 

    public GameObject eggdestroyEffect;
    //private GameObject effect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
            GameObject effect = Instantiate(eggdestroyEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f);
            //(destroyEffect,1f);
            //StartCoroutine(DestroyEffect());
        }
    }



}





