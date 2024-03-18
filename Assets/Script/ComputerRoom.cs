using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerRoom : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        ComputerOpen();
    }

    public GameObject computer;
    public GameObject player;
    public GameObject camPlayer;
    public GameObject theRoof;
    bool hide = false;
    void Start()
    {
        computer.SetActive(false);

    }

    public void TheRoof()
    {
        
        if (hide ==false)
        {
           theRoof.SetActive(false);
           hide = true;
        }
        else
        {
            theRoof.SetActive(true);
            hide = false;
        }
        
    }
    public void ComputerOpen()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        camPlayer.GetComponent<PlayerCam>().enabled = false;
        computer.SetActive(true);
        player.SetActive(false);

    }
    public void ComputerClose()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        camPlayer.GetComponent<PlayerCam>().enabled = true;
        computer.SetActive(false);
        player.SetActive(true);

    }
}
