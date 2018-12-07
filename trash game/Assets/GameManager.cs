using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public int currentPoints = 0;
	public int lives = 3;
	public float generateRate = 7F;
	void Awake()
	{
		instance = this;
	}

	public void AddPoints (int amount){
		currentPoints += amount;

		if(currentPoints % 10 == 0){
			generateRate -= 0.5F;
		}
	}



}
