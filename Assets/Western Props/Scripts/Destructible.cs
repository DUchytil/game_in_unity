// --------------------------------------
// This script is totally optional. It is an example of how you can use the
// destructible versions of the objects as demonstrated in my tutorial.
// Watch the tutorial over at http://youtube.com/brackeys/.
// --------------------------------------


/*
 This code was taken from devassets.com (changes made)
URL: https://devassets.com
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject destroyedVersion;    // Reference to the shattered version of the object

    void OnCollisionEnter(Collision collisionInfo)
    {
        // Check if the collision is with an object tagged as "Obstacle"
        if (collisionInfo.collider.CompareTag("Player") || collisionInfo.collider.CompareTag("Obstacle"))
        {
            Debug.Log("The player hit the crate");

            // Spawn a shattered object
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            // Remove the current object
            Destroy(gameObject);

        }
    }
}




