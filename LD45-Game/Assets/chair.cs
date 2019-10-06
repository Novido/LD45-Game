using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chair : MonoBehaviour
{
    AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        audio.Play();
        audio.loop = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        audio.Stop();
        audio.loop = false;

    }
}
