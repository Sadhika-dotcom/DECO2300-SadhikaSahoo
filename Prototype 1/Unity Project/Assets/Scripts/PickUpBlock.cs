using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBlock : MonoBehaviour
{
    public GameObject pickUpText;
    public GameObject BookOnPlayer;

    void Start()
    {
        pickUpText.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pickUpText.SetActive(true);

            // Check if 'E' key is held down to pick up the Block
            if (Input.GetKey(KeyCode.E))
            {
                gameObject.SetActive(false);
                BookOnPlayer.SetActive(true);
                pickUpText.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pickUpText.SetActive(false);
        }
    }
}
