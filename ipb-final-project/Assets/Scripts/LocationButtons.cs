
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationButtons : MonoBehaviour
{
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
