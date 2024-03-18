using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour , IInteractable
{
    public void Interact()
    {
        MaterialChanging();
    }
    public Material[] materials;
    public GameObject theObject;
    public int change;
    Renderer render;
    void Start()
    {
        change = 0;
        render = theObject.GetComponent<Renderer>();
        render.enabled = true;
        render.sharedMaterial = materials[change];
    }

    // Update is called once per frame
    void Update()
    {
        render.sharedMaterial = materials[change];
    }
     public void MaterialChanging()
    {
        if(change < materials.Length - 1)
        {
            change++;
        }
        else
        {
            change = 0;
        }
    }
}
