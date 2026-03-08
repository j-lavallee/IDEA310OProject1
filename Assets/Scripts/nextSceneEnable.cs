using UnityEngine;
using UnityEngine.SceneManagement;

public class nextSceneEnable : MonoBehaviour
{
    public string scene;

    public void OnEnable()
    {
        SceneManager.LoadScene(scene);
    }
}
