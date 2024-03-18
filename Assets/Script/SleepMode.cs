using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SleepMode : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        SleepModeEnter();
    }

    public GameObject sleepMode;
    public GameObject player;
    public GameObject camPlayer;
    void Start()
    {
        sleepMode.SetActive(false);

    }
    public void SleepModeOn()
    {
        SceneManager.LoadScene(0);
    }
    public void SleepModeEnter()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        camPlayer.GetComponent<PlayerCam>().enabled = false;
        sleepMode.SetActive(true);
        player.SetActive(false);

    }
    public void SleepModeOff()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        camPlayer.GetComponent<PlayerCam>().enabled = true;
        sleepMode.SetActive(false);
        player.SetActive(true);

    }
}
