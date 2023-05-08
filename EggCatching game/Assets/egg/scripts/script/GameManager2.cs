using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class GameManager2 : MonoBehaviour
{

    [SerializeField] GameObject[] eggsPrefabs;
    [SerializeField] float secondSpawn = 0.5f;
    [SerializeField] float minTransform;
    [SerializeField] float maxTransform;



    public Player player_script; // for score
    public TMP_Text text;            // for score      

    public bool gm2 = true;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EggSpawn());
        
    }

    IEnumerator EggSpawn()
    {
        while (gm2 == true)
        {
            yield return new WaitForSeconds(2);

            var wanted = UnityEngine.Random.Range(minTransform, maxTransform);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(eggsPrefabs[UnityEngine.Random.Range(0, eggsPrefabs.Length)],
                position, Quaternion.identity);

            yield return new WaitForSeconds(secondSpawn);
        }
    }


    /* public void StopSpawning()
     {
         CancelInvoke();
     }*/

    // Update is called once per frame
    void Update()
    {

        text.text = player_script.score.ToString();

        

    }











}

