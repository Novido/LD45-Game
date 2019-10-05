using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpGate : MonoBehaviour
{
    public GameObject targetWarpGate;

    Vector3 teleportPosition;

    // Start is called before the first frame update
    void Start()
    {
        teleportPosition = new Vector3(targetWarpGate.transform.position.x + 0.8f, targetWarpGate.transform.position.y);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = teleportPosition;
    }
}
