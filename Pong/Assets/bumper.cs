using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bumper : MonoBehaviour {

    public bool isPaddle1;
    public float speed = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        if (isPaddle1)
        
            transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);
            else 
            transform.Translate(0, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f);

        if(gameObject.transform.position.y >= 4)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 4f, 0);
        }
        if (gameObject.transform.position.y <= -4)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, -4f, 0);
        }



    }
}
