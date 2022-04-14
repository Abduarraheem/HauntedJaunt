using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEffect : MonoBehaviour
{
    PlayerMovement playerScript;
    public GameObject player;
    bool changedSpeedFlag = false;
    // Update is called once per frame
    void Start()
    {
        playerScript = player.GetComponent<PlayerMovement>();
    }
    void FixedUpdate()
    {
        if(!changedSpeedFlag)
        {
            Vector3 direction =  player.transform.position - transform.position;
            direction.Normalize();
            float dotProduct = Vector3.Dot(transform.forward.normalized, direction);
            if (dotProduct > 0)
            {
                changedSpeedFlag = true;
                playerScript.UpdateSpeed();
            }

        }
    }
}
