using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMover : MonoBehaviour {


    public float speed = 5f;


    public bool isMovingUp;
    public bool isMovingRight;


    public float posLastFrameX;
    public float posLastFrameY;

    public float trailDistance = 1;

    public float distanceFromLastFrameX;
    public float distanceFromLastFrameY;



    // Use this for initialization
    void Start() {
        setBallOff();
    }

    // Update is called once per frame
    void Update() {

      /*  distanceFromLastFrameX = posLastFrameX - transform.position.x;
        distanceFromLastFrameY = posLastFrameY - transform.position.y;


        if (distanceFromLastFrameX < 0)
        {
            isMovingRight = true;
        }
        else if (distanceFromLastFrameX > 0)
        {
            isMovingRight = false;
        }
        

        if (distanceFromLastFrameY < 0)
        {
            isMovingUp = true;
        }
        else if (distanceFromLastFrameY < 0)
        {
            isMovingUp = false;
        }



        if(isMovingUp == true)
        {
            trail.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y-trailDistance, 0);
        }

        if (isMovingUp == false)
        {
            trail.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + trailDistance, 0);

        }

        if(isMovingRight == true)
        {
            trail.transform.position = new Vector3(gameObject.transform.position.x-trailDistance, gameObject.transform.position.y, 0);

        }

        if (isMovingRight == false)
        {
            trail.transform.position = new Vector3(gameObject.transform.position.x + trailDistance, gameObject.transform.position.y, 0);

        }

        if(isMovingRight == true && isMovingUp == true)
        {
            trail.transform.position = new Vector3(gameObject.transform.position.x - trailDistance, gameObject.transform.position.y - trailDistance, 0);

        }

        if (isMovingRight == false && isMovingUp == false)
        {
            trail.transform.position = new Vector3(gameObject.transform.position.x + trailDistance, gameObject.transform.position.y + trailDistance, 0);

        }







        posLastFrameX = gameObject.transform.position.x;
        posLastFrameY = gameObject.transform.position.y;

    */

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Bounds"))
        {
            setBallOff();
        }
    }

    IEnumerator resetPos()
    {
        gameObject.SetActive(false);
        yield return new WaitForSeconds (3);
        gameObject.SetActive(true);
        gameObject.transform.position = new Vector3(0, 0, 0);
        setBallOff();


    }

    public void setBallOff()
    {
        gameObject.transform.position = Vector3.zero;
        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sy = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector3(speed * sx, speed * sy, 0);
    }
}
