using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneToLoad; // Set the target scene name in the inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the player enters the collider
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            ChangeScene();
        }
    }

    // Method to load the new scene
    private void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
