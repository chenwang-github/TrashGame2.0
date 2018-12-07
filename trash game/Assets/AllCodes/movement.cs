using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	// Use this for initialization

	public float speed = 50f;

	void Start () {
		gameObject.tag = "trash";
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.LeftArrow)){
            //Debug.Log("left!!!!");
            transform.Translate(speed * Vector3.back * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("right!!!!");
            transform.Translate(speed * Vector3.forward * Time.deltaTime);
        }

    }
}
