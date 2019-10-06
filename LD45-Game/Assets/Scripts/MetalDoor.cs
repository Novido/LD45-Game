using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalDoor : MonoBehaviour
{
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerHandler>().HasKey == true)
        {
            audio.Play();
            transform.position = new Vector3(transform.position.x + 1, transform.position.y);
        }
        

    }
}
