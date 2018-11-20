using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touched : MonoBehaviour {
	public int points = 1;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == gameObject.tag)
        {
            Debug.Log("++");
        }

		GameManager.instance.AddPoints(points);
        Destroy(collision.gameObject);
    }
}
