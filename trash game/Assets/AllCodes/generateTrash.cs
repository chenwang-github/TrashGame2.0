using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateTrash : MonoBehaviour {


	public List<GameObject> recycleSpawn = new List<GameObject>();
	public List<GameObject> compsiteSpawn = new List<GameObject>();
	public List<GameObject> landfillSpawn = new List<GameObject>();


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
			int typeidx = Random.Range(0, 3);
			int itemidx = Random.Range(0, 5);
			GameObject toBeSpawn;

 			if (typeidx == 0){
				toBeSpawn = recycleSpawn[itemidx];
			}else if(typeidx == 1){
				toBeSpawn = compsiteSpawn[itemidx];
			}else{
				toBeSpawn = landfillSpawn[itemidx];
			}

			float sizeZ = GetComponent<Collider>().bounds.size.z / 2;

			Vector3 pos = new Vector3(transform.position.x, transform.position.y, Random.Range(-sizeZ, sizeZ));

			GameObject item = Instantiate(toBeSpawn, pos, Quaternion.identity);

			yield return new WaitForSeconds(GameManager.instance.generateRate);
		}
	}

}
