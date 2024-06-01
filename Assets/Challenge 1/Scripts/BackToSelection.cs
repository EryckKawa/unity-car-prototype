using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToSelection : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("SceneSelector");
        }
    }
}
