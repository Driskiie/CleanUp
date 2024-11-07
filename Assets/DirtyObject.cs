using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DirtyObject : MonoBehaviour
{
    public GameObject DirtySpot;
    public GameObject DirtyObj;
    public GameObject CleanObj;
    public XRBaseInteractable interactable;
    public AudioSource placed;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Dirty")) 
        {

            DirtySpot.SetActive(false);
            DirtyObj.SetActive(false);
            CleanObj.SetActive(true);
            placed.Play();
        
        }
    }
}