using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOff : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        LightsOut();
    }

    public GameObject lights;
    bool off = false;
    public void LightsOut()
    {
        if (off == false)
        {
            lights.SetActive(false);
            off = true;
        }
        else
        {
            lights.SetActive(true);
            off = false;
        }
    }

}
