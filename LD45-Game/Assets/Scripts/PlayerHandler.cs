using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHandler : MonoBehaviour
{
    public GameObject bloodSplat;
    //public GameObject LevelChanger;
    SpriteRenderer sr;

    public bool hasKey = false;
    public bool isDead = false;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public bool HasKey
    {
        get { return hasKey; }
        set { hasKey = value; }
    }

    private void FixedUpdate()
    {
        if(isDead == true)
        {
            Instantiate(bloodSplat, new Vector3(transform.position.x, transform.position.y), Quaternion.identity);
            
            //Debug.Log("Is Dead");
            StartCoroutine(SetTimer());

            //Destroy(gameObject);
            sr.enabled = false;

        }
    }

    IEnumerator SetTimer()
    {
        //Debug.Log("Waiting");
        yield return new WaitForSeconds(2);
        //Debug.Log("Done!");
        SceneManager.LoadScene("GameOver");
    }

}
