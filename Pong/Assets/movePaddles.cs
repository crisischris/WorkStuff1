using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePaddles : MonoBehaviour
{


    public float speed;

    public bool atBounds = false;

    public KeyCode UP;
    public KeyCode DOWN;

    public GameObject ball;

    public float ballPos;
    public float startPosX;
    public float startPosZ;


    // Use this for initialization
    void Start()
    {
        speed = 3f;

        startPosX = gameObject.transform.position.x;
        startPosZ = gameObject.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        ballPos = ball.transform.position.y;


        gameObject.transform.position = (new Vector3(gameObject.transform.position.x, ball.transform.position.y, gameObject.transform.position.z));

        /// hand unpit module


        if (Input.GetKey(UP))
        {
            transform.Translate(Vector3.up * (Time.deltaTime * speed));

            if (gameObject.transform.position.y >= .7 || gameObject.transform.position.y <= -.7)
            {
                speed = 0;
                atBounds = true;
            }

            else if (gameObject.transform.position.y <= .7 && gameObject.transform.position.y >= -.7)
            {
                speed = 3;
                atBounds = false;
            }
        }

        if (Input.GetKey(DOWN))
        {
            
            speed = 3;
            

            transform.Translate(Vector3.down * (Time.deltaTime * speed));

            if (gameObject.transform.position.y >= .7 || gameObject.transform.position.y <= -.7)
            {
                speed = 0;
                atBounds = true;
            }

           else if (gameObject.transform.position.y <= .7 && gameObject.transform.position.y >= -.7)
            {
                speed = 3;
                atBounds = false;
            }
        }



    }

    void OnTriggerEnter(Collider col)
    {

    }
}
