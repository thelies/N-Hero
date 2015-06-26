using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BamboosController : MonoBehaviour {

	[SerializeField] Bamboo prefabBamboo;
	List<Bamboo> bamboos = new List<Bamboo>();
	// Use this for initialization
	void Start () {
		Bamboo bamboo;
		float x;
		float y;
		float s;
		Vector3 pos;
		Vector3 scale;
		float width = Screen.width/100;
		float height = Screen.height/100;
		Debug.Log ("Width: " + Screen.width);
		while (transform.childCount < 2 ) {
			bamboo = Instantiate(prefabBamboo) as Bamboo;
			bamboo.transform.parent = gameObject.transform;
			if (bamboos.Count == 0) {
				x = (float)Random.Range(3 * width/5, width/10) * -1;
				y = (float)Random.Range(3 * height/5, height) * -1;
				pos = new Vector3(x, y, 0);

				s = (float)Random.Range(1.0f, 2.0f);
				scale = bamboo.transform.localScale;
				scale.x = s;

				bamboo.transform.localPosition = pos;
				bamboo.transform.localScale = scale;
				bamboos.Add(bamboo);
			} else {
				Vector3 preBambooPos = bamboos[bamboos.Count - 1].transform.localPosition;
				x = (float)Random.Range(width/3, width/2);
				y = (float)Random.Range(3 * height/5, height) * -1;
				pos.x = preBambooPos.x + x;
				pos.y = y;
				pos.z = 0;

				s = (float)Random.Range(1.0f, 2.0f);
				scale = bamboo.transform.localScale;
				scale.x = s;

				bamboo.transform.localPosition = pos;
				bamboo.transform.localScale = scale;
				bamboos.Add(bamboo);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
