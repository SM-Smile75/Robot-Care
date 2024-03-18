using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialList : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        TutorialOpen();
    }

    public GameObject tutorial;
    public GameObject player;
    public GameObject camPlayer;

    void Start()
    {
       tutorial.SetActive(false);
       
    }

    public void TutorialOpen()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        camPlayer.GetComponent<PlayerCam>().enabled=false;
        tutorial.SetActive(true);
        player.SetActive(false);

    }
    public void TutorialClose()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        camPlayer.GetComponent<PlayerCam>().enabled = true;
        tutorial.SetActive(false);
        player.SetActive(true);

    }
    void Update()
    {
        
    }
}
