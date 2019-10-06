using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    GameObject player;
    AudioSource audio;

    private void Start()
    {
        player = GameObject.Find("Player");
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<PlayerHandler>().HasKey = true;
        audio.Play();

        //Destroy(gameObject);
        gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
    }
}
