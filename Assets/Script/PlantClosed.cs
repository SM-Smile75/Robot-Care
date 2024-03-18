using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantClosed : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        OpenPlantDoor();
    }

    public GameObject plants;
    Animator anim;
    bool plantDoor;
    void Start()
    {
        plantDoor = false;
        anim = plants.GetComponent<Animator>();
        
    }

    public void OpenPlantDoor()
    {
        if(plantDoor == false) 
        { 
            anim.SetBool("Button Pressed", true); 
            plantDoor = true;
        }
        else
        {
            anim.SetBool("Button Pressed", false);
            plantDoor = false;
        }
        
    }


}
