using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayScore : MonoBehaviour {


    private void Start()
    {
        //GetComponent<TextMesh>().text = "my string";
    }
    // Update is called once per frame
    void Update () {
        GetComponent<TextMesh>().text = "Score : " + Globals.score.ToString();
        Debug.Log(GetComponent<TextMesh>().text);
    }
}
