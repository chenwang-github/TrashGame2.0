using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change : MonoBehaviour {

    public Material recycle;
    public Material trash;
    public Material compost;
    public Renderer rend;
    public int count = 0;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space)){
            if(count % 3 == 0){
                rend.sharedMaterial = compost;
                gameObject.tag = "compost";
            }
            if (count % 3 == 1)
            {
                rend.sharedMaterial = recycle;
                gameObject.tag = "recycle";
            }
            if (count % 3 == 2)
            {
                rend.sharedMaterial = trash;
                gameObject.tag = "trash";
            }
            count++;
        }
	}
}
