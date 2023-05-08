using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
   public bool CanMove = true;

    [SerializeField]
    float maxpos;

    [SerializeField]
    float Movespeed;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CanMove)
        {
            Move();
        }
    }

    private void Move()
    {
      
        float inputx = Input.GetAxis("Horizontal");

        transform.position += Vector3.right * inputx * Movespeed * Time.deltaTime;

        float xpos = Mathf.Clamp(transform.localPosition.x, -maxpos, maxpos);

        transform.localPosition = new Vector3(xpos, transform.localPosition.y, transform.localPosition.z);
    }

    
}
