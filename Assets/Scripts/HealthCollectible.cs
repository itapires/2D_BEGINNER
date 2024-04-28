using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider2D)
    {
        Debug.Log("Object that entered the trigger : " + collider2D);
    }
}
