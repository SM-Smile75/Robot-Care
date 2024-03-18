using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSesame : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        OpenDoor();
    }

    Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        animator.SetTrigger("Open");
    }
    void Update()
    {
        
    }
}
