using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touched : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == gameObject.tag)
        {
            Globals.score += 1;
            if(Globals.meter <=4.8){
                Globals.meter += 0.2;
            }

        }else{
            Globals.meter--;
            if(Globals.meter<0){
                Globals.gg = true;
            }
        }

       //Debug.Log(Globals.score);

        Destroy(collision.gameObject);
    }
}
