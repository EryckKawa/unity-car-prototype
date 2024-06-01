using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    public void LoadCarScene()
    {
        SceneManager.LoadScene("Prototype 1");
    }

    public void LoadPlaneScene()
    {
        SceneManager.LoadScene("Challenge 1");
    }
}
