using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        
        float inputY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * speed * inputY * Time.deltaTime);
        
        
        if(transform.position.y>4.5f) // && transform.position.y > -4.5f)
        {
            transform.position = new Vector3(transform.position.x, 4.5f, 0);
        }
        else if(transform.position.y < -4.5f)
        {
            transform.position = new Vector3(transform.position.x, -4.5f, 0);
        }
        
        if(transform.position.x > 7f)
        {
            transform.position = new Vector3(7f,transform.position.y, 0);
        }
        else if(transform.position.x < -7f)
        {
            transform.position = new Vector3(-7f,transform.position.y, 0);
        }
    }
}
