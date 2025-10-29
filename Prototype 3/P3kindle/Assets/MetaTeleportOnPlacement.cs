using UnityEngine;

public class MetaTeleportOnPlacement : MonoBehaviour
{
    [Header("Teleport Settings")]
    public Transform teleportTarget;        // Target to teleport to (TeleportPoint_Forest)
    public GameObject playerRig;            // [BuildingBlock] Camera Rig reference
    public string requiredObjectTag = "PickupCube"; // Tag on object to trigger teleport

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(requiredObjectTag))
        {
            TeleportPlayer();
        }
    }

    private void TeleportPlayer()
    {
        if (playerRig != null && teleportTarget != null)
        {
            playerRig.transform.position = teleportTarget.position;
            playerRig.transform.rotation = teleportTarget.rotation;
            Debug.Log("Teleported player to: " + teleportTarget.name);
        }
        else
        {
            Debug.LogWarning("MetaTeleportOnPlacement: Missing references!");
        }
    }
}
