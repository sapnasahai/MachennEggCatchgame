using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAnim : MonoBehaviour
{
    public GameObject destroyEffect;
    //private GameObject effect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
            GameObject effect = Instantiate(destroyEffect, transform.position, Quaternion.identity);
            Destroy(effect, 1f); 
            //(destroyEffect,1f);
            //StartCoroutine(DestroyEffect());
        }
    }

    /*public IEnumerator DestroyEffect()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);

    }*/
}
