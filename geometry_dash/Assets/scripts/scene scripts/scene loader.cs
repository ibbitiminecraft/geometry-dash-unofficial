using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    public void Sceneloader(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
