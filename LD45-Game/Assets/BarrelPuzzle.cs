using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelPuzzle : MonoBehaviour
{
    public GameObject barrel1;
    public GameObject barrel2;
    public GameObject barrel3;

    public GameObject chest;

    int colorIndexB1;
    int colorIndexB2;
    int colorIndexB3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        colorIndexB1 = barrel1.GetComponent<BarrelLogic>().GetColorIndex;
        colorIndexB2 = barrel2.GetComponent<BarrelLogic>().GetColorIndex;
        colorIndexB3 = barrel3.GetComponent<BarrelLogic>().GetColorIndex;

        if(colorIndexB1 == 1 && colorIndexB2 == 2 && colorIndexB3 == 3)
        {
            Instantiate(chest, new Vector3(0, 1.5f, 0), Quaternion.identity);
        }

    }
    
}
