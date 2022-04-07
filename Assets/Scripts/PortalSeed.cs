using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSeed : MonoBehaviour
{
    // Reference to the portal
    public GameObject portalPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("floor")) // If the tag of the collision object is "floor"
        {
            // Create the portall
            Instantiate(portalPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            // Destroy the seed
            Destroy(gameObject);
        }
    }
}
