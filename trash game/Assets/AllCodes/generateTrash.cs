using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateTrash : MonoBehaviour {

	public List<GameObject> itemsToSpawn = new List<GameObject>();
	//public float generateRate = 7F;
	bool dropping;

	// Use this for initialization
	void Start()
	{
		StartCoroutine("Generate");
	}

	IEnumerator Generate()
	{
		if (dropping)
		{
			yield break;
		}
		dropping = true;

		while (true)
		{
			int num = Random.Range(0, itemsToSpawn.Count);
			float sizeZ = GetComponent<Collider>().bounds.size.z / 2;

			Vector3 pos = new Vector3(transform.position.x, transform.position.y, Random.Range(-sizeZ, sizeZ));

			GameObject item = Instantiate(itemsToSpawn[num], pos, Quaternion.identity);

			yield return new WaitForSeconds(GameManager.instance.generateRate);
		}
	}

}
