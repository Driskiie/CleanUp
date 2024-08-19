using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class AnimateHandController : MonoBehaviour
{
    public InputActionReference gripIAR;
    public InputActionReference triggerIAR;

    private Animator _handAnimator;
    private float _gripValue;
    private float _triggerValue;

    void Start()
    {
        _handAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimateGrip();
        AnimateTrigger();
    }
    private void AnimateGrip() 
    {
        _gripValue = gripIAR.action.ReadValue<float>();
        _handAnimator.SetFloat("Grip", _gripValue);
    
    
    }
    private void AnimateTrigger() 
    {

        _triggerValue = triggerIAR.action.ReadValue<float>();
        _handAnimator.SetFloat("Trigger", _triggerValue);



    }
}
