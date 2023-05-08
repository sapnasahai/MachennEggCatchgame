using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombmanger : MonoBehaviour
{

    [SerializeField] GameObject bomb_Prefabs;

   

    //public bool bm1 = true;



    void Start()
    {

       
        InvokeRepeating("Spawnbomb", 7, 7);
    }

    void Spawnbomb()
    {
        
            float tempPos = Random.Range(-7.9f, 7.9f);
            Instantiate(bomb_Prefabs, new Vector3(tempPos, 5.5f, 0), Quaternion.identity);
        
       
    }


   





    // Update is called once per frame
    void Update()
    {
        
    }
}
