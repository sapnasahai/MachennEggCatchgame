using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{


    [SerializeField] GameObject[] eggsPrefabs;
    [SerializeField] float secondSpawn = 1.0f;
     
    [SerializeField] float minTransform;
    [SerializeField] float maxTransform;

    public bool gm1= true;

    public GameObject Egg_normal;

    public Player player_script; // for score
    public TMP_Text text;            // for score      



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EggSpawn());
    }

    IEnumerator EggSpawn()
    {
        while (gm1==true)
        {
            yield return new WaitForSeconds(1);

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
