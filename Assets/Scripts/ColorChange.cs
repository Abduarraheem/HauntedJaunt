using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Credit: Referenced Color.Lerp docs https://docs.unity3d.com/ScriptReference/Color.Lerp.html.
public class ColorChange : MonoBehaviour
{
    Color yellow = Color.yellow;
    Color clear = Color.clear;
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
        // Linear interpolation between yellow and clear.
        r.material.color = Color.Lerp(yellow, clear, Mathf.PingPong(timer, 1));
    }
}
