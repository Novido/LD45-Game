using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelLogic : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Color startColor;
    AudioSource audio;

    int colorChanged = 0;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        startColor = spriteRenderer.color;
        audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audio.Play();

        if (colorChanged == 4)
        {
            colorChanged = 0;
        }

        if (colorChanged == 0) // 1
        {
            spriteRenderer.color = Color.red;
        }

        if (colorChanged == 1) // 2
        {
            spriteRenderer.color = Color.green;
        }

        if (colorChanged == 2) // 3
        {
            spriteRenderer.color = Color.blue;
        }

        if (colorChanged == 3) // 4
        {
            spriteRenderer.color = startColor;
        }

        colorChanged += 1;
    }

    public int GetColorIndex
    {
        get { return colorChanged; }
    }
}
