using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickeame : MonoBehaviour {
    public GameObject wave;
    public Rigidbody2D rb;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            //Debug.Log(pos + " " + Input.mousePosition);
            //wave.transform.position = pos;
            Instantiate(wave, new Vector3(pos.x, pos.y, -1), Quaternion.identity);

            //wave.AddComponent<Rigidbody2D>();
            //rb = wave.GetComponent<Rigidbody2D>();
            //rb.bodyType = RigidbodyType2D.Static;
            //rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;

            //Instantiate(wave, new Vector2(Input.mousePosition.x, Input.mousePosition.y), Quaternion.identity);
        }
    }
}
