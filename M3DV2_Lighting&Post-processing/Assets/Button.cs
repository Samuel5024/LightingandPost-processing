using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
   public void LoadLightProbes()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadLightingScene()
    {
        SceneManager.LoadScene(1);
    }
}
