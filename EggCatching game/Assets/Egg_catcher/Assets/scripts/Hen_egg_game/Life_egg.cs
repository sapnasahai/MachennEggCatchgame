using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_egg : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (transform.localPosition.x < -500 || transform.localPosition.x > 500)
        {
            Destroy(gameObject);
        }
    }

    public float gravity;
    void FixedUpdate()
    {
     
            rb.velocity = new Vector3(0, gravity, 0);
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (Gamemanager.instance.livesSlider.value < Gamemanager.instance.livesSlider.maxValue)
            {
                Gamemanager.instance.Incrementlives();
            }
 
            Destroy(gameObject);
        }
        else if (collider.gameObject.tag == "Boundary")
        {

            Destroy(gameObject);
        }
    }
}
