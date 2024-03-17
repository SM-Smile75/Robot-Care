using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
   
    public string interactableTag = "Interactable";

    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
            
                if (hit.collider.CompareTag(interactableTag))
                {
                    
                    Debug.Log("Interacted with: " + hit.collider.gameObject.name);

                   
                    hit.collider.gameObject.SendMessage("Interact", SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}