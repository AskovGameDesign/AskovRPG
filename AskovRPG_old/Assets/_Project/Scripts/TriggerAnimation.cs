using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 

[RequireComponent(typeof(SphereCollider))]
public class TriggerAnimation : MonoBehaviour
{
    public Animator triggerAnimator;
    public string animationName = "animationName";
    public bool toggleOnTrigger = true; 

    SphereCollider sphereCollider;
    AnimatorControllerParameter[] controllerParameters; 


    // Start is called before the first frame update
    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
        sphereCollider.isTrigger = true;

        if (triggerAnimator)
            controllerParameters = triggerAnimator.parameters;

        foreach (var cp in controllerParameters)
        {
            Debug.Log(cp.name + " -- " + cp.type);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "Player")
        {
            return;


        }

        if (triggerAnimator != null)
        {
            if(toggleOnTrigger)
                triggerAnimator.SetBool(animationName, !triggerAnimator.GetBool(animationName));
        }
    }
}
