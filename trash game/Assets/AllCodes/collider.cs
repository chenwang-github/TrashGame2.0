using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour {
    

    Collider myCollider;

    void Start()
    {
        //Fetch the GameObject's Collider (make sure it has a Collider component)
        myCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update () {

        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("enable!!!!");
            myCollider.enabled = false;
        }
        
	}
}
