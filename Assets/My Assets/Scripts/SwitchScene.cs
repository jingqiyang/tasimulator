using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour
{
    public void switchScene(string sceneName) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
