using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadNote : MonoBehaviour
{
    //GameObject canvasObject;
    private Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        //canvasObject = GameObject.Find("Canvas");
        canvas = GetComponentInChildren<Canvas>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //canvasObject.SetActive(true);
        canvas.enabled = true;
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //canvasObject.SetActive(false);
        canvas.enabled = false;
    }
}
