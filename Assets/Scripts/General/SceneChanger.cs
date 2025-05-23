using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneToLoad; // Set this in the Inspector

    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
