using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayChance: MonoBehaviour
{
    string s;

    private void Start()
    {
        //GetComponent<TextMesh>().text = "my string";
    }

    void Update()
    {
        s = "Chance : ";
        int i = 0;
        double chance = Globals.meter;
       while (i<5){
            if(chance>0){
                s += "x";
                chance--;
            }else{
                s += "-";
            }
            i++;
        }
        //while(chance>0){
        //    s += "x";
        //    chance--;
        //}

 
        GetComponent<TextMesh>().text = s;
        //Debug.Log("meter : " + s);//Globals.score.ToString();)
    }
}
