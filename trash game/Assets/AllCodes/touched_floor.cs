using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touched_floor : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        {
            Globals.meter -= 1;
            if(Globals.meter < 0){
                Globals.gg = true;
            }
        }
        //Debug.Log("chance = " + Globals.meter);


        Destroy(collision.gameObject);
    }
}
