using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{

    public PlayerInventory playerInventory;
    public int keysRequired = 2;
    public GameObject door;
    public Text notificationText; // Reference to the UI Text element
    public float displayDuration = 2f; // Time in seconds the message will be displayed

    private void OnEnable()
    {
        playerInventory.OnKeyCollected.AddListener(CheckKeys);
    }

    private void OnDisable()
    {
        playerInventory.OnKeyCollected.RemoveListener(CheckKeys);
    }

    private void CheckKeys(PlayerInventory inventory)
    {
        if (inventory.NumberOfKeys >= keysRequired)
        {
            Destroy(door);
            ShowDoorOpenedMessage(); 
        }
    }

    private void ShowDoorOpenedMessage()
    {
        StartCoroutine(DisplayMessage());
    }

    private IEnumerator DisplayMessage()
    {
        notificationText.gameObject.SetActive(true);
        notificationText.text = "A door has opened!"; // Set your message here
        yield return new WaitForSeconds(displayDuration);
        notificationText.gameObject.SetActive(false);
    }
}
