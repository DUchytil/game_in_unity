using TMPro;
using UnityEngine;





/*
 Following code inspired by Brackeys YouTube channel (changes made)
URL: https://www.youtube.com/watch?v=j48LtUkZRjU&list=PLPV2KyIb3jR5QFsefuO2RlAgWEz6EvVi6
 */




public class PlayerCollision : MonoBehaviour
{
    // Reference to the PlayerMovement component
    public PlayerMovement movement;

    // Reference to the new material you want to apply
    public Material newMaterialAfterCollision;

    // Reference to the score text to change color
    public TextMeshProUGUI scoreText;

    // This function will be called whenever something collides
    void OnCollisionEnter(Collision collisionInfo)
    {
        // Check if the collision is with an object tagged as "Obstacle"
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            Debug.Log("We hit the obstacle");

            // Disable player movement when colliding with an obstacle
            movement.enabled = false;

            // Change the material color
            ChangeMaterialColor(newMaterialAfterCollision);

            // Change the color of the score text
            ChangeScoreTextColor(Color.red); // You can replace Color.red with your desired color
        }
    }

    //Function generated by ChatGPT
    // Function to change the material color
    void ChangeMaterialColor(Material newMaterialAfterCollision)
    {
        // Get the Renderer component of the player object
        Renderer playerRenderer = GetComponent<Renderer>();

        // Check if the Renderer component is found
        if (playerRenderer != null)
        {
            // Assuming the object has a Renderer component, change the material
            playerRenderer.material = newMaterialAfterCollision;
        }
        else
        {
            // Log an error if the Renderer component is not found
            Debug.LogError("Renderer component not found on the player object.");
        }
    }


    //Function generated by ChatGPT
    // Function to change the color of the score text
    void ChangeScoreTextColor(Color newColor)
    {
        // Check if the TextMeshProUGUI component is found
        if (scoreText != null)
        {
            // Assuming the object has a TextMeshProUGUI component, change the color
            scoreText.color = newColor;
        }
        else
        {
            // Log an error if the TextMeshProUGUI component is not found
            Debug.LogError("TextMeshProUGUI component not found on the player object.");
        }
    }
}
