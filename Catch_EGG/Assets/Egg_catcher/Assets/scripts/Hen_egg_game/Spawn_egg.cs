using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_egg : MonoBehaviour
{
    //public List<float> Bird_x_pos = new List<float>();
    [SerializeField]
    float maxX;

   // public float intervalspwan;

    public GameObject Egg_prefab,bomb_prefab, Life_prefab, Score_prefab, egg_pos,Bomb_parent;
    // Start is called before the first frame update
    void Start()
    {
         
        //InvokeRepeating("SpawnBomb", 1, 3f);
        InvokeRepeating("Spawn_life_egg", 2, 4f);
        InvokeRepeating("Spawn_score_egg", 2, 10f);
        startSpwanBomb();
    }

    // Update is called once per frame
    void Update()
    {
    //
    }

    public void SpawnEgg()
    {
            GameObject obj = Instantiate(Egg_prefab);
            obj.transform.parent = egg_pos.transform;
            obj.transform.localPosition = Vector3.zero;
            obj.transform.localScale = Vector3.one;
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            rb.useGravity = true;
            obj.transform.parent = transform.parent.gameObject.transform;

    }

    public void SpawnBomb()
    {
        GameObject obj = Instantiate(bomb_prefab);
        obj.transform.parent = egg_pos.transform;
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localScale = Vector3.one;
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        rb.useGravity = true;
        obj.transform.parent = transform.parent.gameObject.transform;
    }
    public void Spawn_life_egg()
    {
        GameObject obj = Instantiate(Life_prefab);
        obj.transform.parent = egg_pos.transform;
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localScale = Vector3.one;
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        rb.useGravity = true;
        obj.transform.parent = transform.parent.gameObject.transform;

    }
    public void Spawn_score_egg()
    {
        GameObject obj = Instantiate(Score_prefab);
        obj.transform.parent = egg_pos.transform;
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localScale = Vector3.one;
        Rigidbody rb = obj.GetComponent<Rigidbody>();
        rb.useGravity = true;
        obj.transform.parent = transform.parent.gameObject.transform;

    }


    void Spawn_Bomb_random()
    {

        float randomx = Random.Range(-maxX, maxX);

        Vector3 Randompos = new Vector3(randomx, 360, 0);

        GameObject obj = Instantiate(bomb_prefab);

        obj.transform.parent = Bomb_parent.transform;
        obj.transform.localPosition = Randompos;
        obj.transform.localScale = Vector3.one;


    }

    IEnumerator spwan_bomp_enum()
    {
        yield return new WaitForSeconds(5f);

        while (true)
        {
            Spawn_Bomb_random();

            yield return new WaitForSeconds(5);
        }

    }

    public void startSpwanBomb()
    {
        StartCoroutine("spwan_bomp_enum");
    }
    public void stopSpwanBomb()
    {
        StopCoroutine("spwan_bomp_enum");
    }


}
