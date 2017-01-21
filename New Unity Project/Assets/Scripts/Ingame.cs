using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingame : MonoBehaviour {
	public GameObject wave;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector2 pos = Camera.main.ScreenToWorldPoint (new Vector2 (Input.mousePosition.x, Input.mousePosition.y));
			Debug.Log (pos + " " + Input.mousePosition);
            //wave.transform.position = pos;
			Instantiate (wave, new Vector3(pos.x, pos.y, -1), Quaternion.identity);
            //Instantiate(wave, new Vector2(Input.mousePosition.x, Input.mousePosition.y), Quaternion.identity);
        }
    }
}
