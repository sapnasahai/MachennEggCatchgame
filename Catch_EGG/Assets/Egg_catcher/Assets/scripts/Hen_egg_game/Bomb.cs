using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour
{
    Rigidbody rb;
    public Image Bomb_image;
    public Sprite Bomb_Blast;

    bool isBombBlast = false;
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
        if (isBombBlast == false)
        {
            rb.velocity = new Vector3(0, gravity, 0);
        }

        // rb.velocity
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Gamemanager.instance.Decrementlives();
           // Destroy(gameObject);


            isBombBlast = true;
            Destroy(rb);
            Bomb_image.sprite = Bomb_Blast;

            StartCoroutine(BombBlast());
            //Destroy(gameObject);
        }
        else if (collider.gameObject.tag == "Boundary")
        {
           // Gamemanager.instance.Decrementlives();
            Debug.Log("Bomb blast");
            //Destroy(rb);

            isBombBlast = true;
            Destroy(rb);
            Bomb_image.sprite = Bomb_Blast;

            StartCoroutine(BombBlast());

        }
    }

    public IEnumerator BombBlast()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);

    }
}
