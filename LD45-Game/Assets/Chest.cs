using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chest : MonoBehaviour
{
    AudioSource audio;
    GameObject levelChanger;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        levelChanger = GameObject.Find("LevelChanger");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        audio.Play();

        StartCoroutine(SetTimer());
    }

    IEnumerator SetTimer()
    {        
        yield return new WaitForSeconds(2);

        levelChanger.GetComponent<LevelChanger>().FadeToLevel("Victory");
        //SceneManager.LoadScene("Victory");
    }
}
