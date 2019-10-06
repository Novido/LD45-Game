using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLane : MonoBehaviour
{
    public GameObject car;
    bool isCarRunning = false;
    AudioSource audio;

    float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (isCarRunning == true)
        {
            car.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audio.Play();
        isCarRunning = true;
    }
}
