using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainBuilder : MonoBehaviour {

	public GameObject prefab;

	public void Update() 
	{
		if(Input.GetMouseButtonUp(0))
		{
			Ray ray  = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast(ray, out hit))
			{

				if(hit.collider.tag == "Terrain")
				{
					Vector3 placePos = hit.point;
					placePos.y += 0.5f;
					placePos.x = Mathf.Round(placePos.x);
					placePos.z = Mathf.Round(placePos.z);
					Instantiate (prefab, placePos, Quaternion.identity);
				}
			}
		}
	}

}
