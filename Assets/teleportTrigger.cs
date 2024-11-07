using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportTrigger : MonoBehaviour
{
    public Transform teleportLocation;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = teleportLocation.position;
        }
    }
}