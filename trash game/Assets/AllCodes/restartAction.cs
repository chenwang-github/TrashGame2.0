using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartAction : MonoBehaviour {

    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("aaaaaa");
            Globals.score = 0;
            Globals.meter = 5;
            Globals.gg = false;
            transform.position = new Vector3(64, -64, 7);

        }
    }

}
