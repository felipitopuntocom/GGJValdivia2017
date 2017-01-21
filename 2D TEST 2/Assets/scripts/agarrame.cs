using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agarrame : MonoBehaviour {

    float distance = 10;
    private Camera cameraFreeWalk;
    public float zoomSpeed = 20f;
    public float minZoomFOV = 10f;

    void OnMouseDrag()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosigtion = Camera.main.ScreenToWorldPoint(mousePosition);
        //transform.position = objPosigtion;
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
        rb.transform.position = objPosigtion;
        //Debug.Log("aaaa me estan agarrando");
    }

    /*
    public void ZoomIn()
    {
        cameraFreeWalk.fieldOfView -= zoomSpeed / 8;
        if (cameraFreeWalk.fieldOfView < minZoomFOV)
        {
            cameraFreeWalk.fieldOfView = minZoomFOV;
        }
    }*/
}
