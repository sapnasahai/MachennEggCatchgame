using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Egg : MonoBehaviour
{
    Rigidbody rb;
    public Image Egg_image;
    public Sprite Broken_egg;

    bool isEggBroken = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Image>();
        rb = GetComponent<Rigidbody>();
        if (transform.localPosition.x < -500 || transform.localPosition.x > 500)
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float gravity;
    void FixedUpdate()
    {
        if (isEggBroken == false)
        {
            rb.velocity = new Vector3(0, gravity, 0);
        }
       
        // rb.velocity
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Gamemanager.instance.Increamentscore();
            Destroy(gameObject);
        }
        else if (collider.gameObject.tag == "Boundary")
        {
            Gamemanager.instance.Decrementlives();
            Debug.Log("Egg broken");
            //Destroy(rb);

            isEggBroken = true;
            Destroy(rb);
            Egg_image.sprite = Broken_egg;

            StartCoroutine(BrokeEgg());
            
        }
    }

    public IEnumerator BrokeEgg()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);

    }
}
