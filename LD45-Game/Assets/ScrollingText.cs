using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollingText : MonoBehaviour
{
    RectTransform rect;
    float speed = 50;

    GameObject levelChanger;

    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        levelChanger = GameObject.Find("LevelChanger");
    }

    // Update is called once per frame
    void Update()
    {
        rect.transform.Translate(Vector3.up * speed * Time.deltaTime);
        //Debug.Log(rect.position.y.ToString());
        if (rect.position.y > 1500)
        {
            levelChanger.GetComponent<LevelChanger>().FadeToLevel("Main Menu");
            //lc.FadeToLevel("Main Menu");
        }
    }
}
