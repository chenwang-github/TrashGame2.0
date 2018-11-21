using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//starting at y = -64.2
//end at y = 270

public class endGame : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Globals.gg == true){
            if (transform.position.y <= 270)
            {
                transform.position += Vector3.up * Time.deltaTime * 60;
            }
        }
	}
}
