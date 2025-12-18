using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for SceneManager.LoadScene()

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    // Removed: playerAnim
    // Removed: collisionFX
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject fadeOut;

    void OnTriggerEnter(Collider other)
    {
        // Start the game over sequence
        StartCoroutine(CollisionEnd());
    }

    IEnumerator CollisionEnd()
    {
        // 1. Stop player movement
        // Assumes thePlayer GameObject has the PlayerMovement script attached
        thePlayer.GetComponent<PlayerMovement>().enabled = false;

        // Removed: collisionFX.Play();
        // Removed: playerAnim.GetComponent<Animator>().Play("Stumble Backwards");

        // 2. Play camera animation (e.g., shake)
        mainCam.GetComponent<Animator>().Play("CollisionCam");

        // 3. Wait for 3 seconds to let effects finish
        yield return new WaitForSeconds(3);

        // 4. Activate the fade-out screen (hides the scene)
        fadeOut.SetActive(true);

        // 5. Wait for another 3 seconds (for the fade-out transition)
        yield return new WaitForSeconds(3);

        // 6. Load the Main Menu scene (Scene 0)
        SceneManager.LoadScene(0);
    }
}