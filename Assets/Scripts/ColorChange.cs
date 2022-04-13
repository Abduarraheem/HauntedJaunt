using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    Color yellow = Color.yellow;
    Color green = Color.green;
    Renderer r;
    float timer = 0;

    void Start()
    {
        r = GetComponent<Renderer>();
    }

    void Update()
    {
        // increasing our own timer here, incase timer needs to be reset based on condition.
        timer += Time.deltaTime; 
        // Linear interpolation between yellow and green.
        r.material.color = Color.Lerp(yellow, green, Mathf.PingPong(timer, 1));
    }
}
