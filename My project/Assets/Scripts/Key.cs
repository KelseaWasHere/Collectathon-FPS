using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public AudioSource audio;
    public float rotationSpeed = 280f; // Rotation speed in degrees per second

    private void Update()
    {
        // Rotate the key around the y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory inventory = other.GetComponent<PlayerInventory>();

        if (inventory != null)
        {
            inventory.KeyCollected();
            audio.Play();
            gameObject.SetActive(false);
        }
    }
}
