using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_FSM : MonoBehaviour
{

    bool moveUp = true;
    bool moveDown = false;
    bool moveRight = false;
    bool moveLeft = false;

    float switchValue = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveUp)
        {
            transform.Translate(Vector3.up * Time.deltaTime);
            if(transform.position.y > switchValue)
            {
                moveUp = false;
                moveRight = true;
            }
        }
        if (moveRight)
        {
            transform.Translate(Vector3.right * Time.deltaTime);
            if (transform.position.x > switchValue)
            {
                moveDown = true;
                moveRight = false;
            }
        }
        if (moveDown)
        {
            transform.Translate(Vector3.down * Time.deltaTime);
            if (transform.position.y < -switchValue)
            {
                moveDown = false;
                moveLeft = true;
            }
        }
        if (moveLeft)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
            if (transform.position.x < -switchValue)
            {
                moveUp = true;
                moveLeft = false;
            }
        }
    }
}
