using UnityEngine;
using System.Collections;

public class chocame : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("me estoy chocando!!!!");
        /*
        if (col.gameObject.tag == "botepapel")
        {
            //Destroy(col.gameObject);
            Debug.Log("me pego");
        }
        */
    }
}