using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressPlate : MonoBehaviour
{
    public GameObject BookShelf;
    bool isPressed = false;
    Vector3 startPosition;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = BookShelf.transform.position;
        audio = GetComponentInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isPressed == true)
        {
            BookShelf.transform.position = new Vector3(startPosition.x + 1, startPosition.y);
        }
        else
        {
            BookShelf.transform.position = startPosition;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPressed = true;
        audio.Play();

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPressed = false;
        audio.Play();
    }
}
