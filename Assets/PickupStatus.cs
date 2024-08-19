using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PickupStatus : MonoBehaviour
{
    private XRGrabInteractable interactable;

    public bool IsHeld { get; private set; }

    void Start()
    {
        interactable = GetComponent<XRGrabInteractable>();
        if (interactable == null)
        {
            Debug.LogError("XRGrabInteractable component is missing on this GameObject.");
        }
    }

    void Update()
    {
        if (interactable != null)
        {
            IsHeld = interactable.isSelected;
        }
    }
}