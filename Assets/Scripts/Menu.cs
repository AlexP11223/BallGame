using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    void Start()
    {
        // handle it here to avoid unnecessary regeneration of the scene in newer Unity version
        bool canQuit = Application.platform != RuntimePlatform.WebGLPlayer;
        if (!canQuit)
        {
            if (gameObject.name == "QuitButton")
            {
                gameObject.SetActive(false);
            }
            if (gameObject.name == "RestartButton")
            {
                var btn = gameObject.GetComponent<RectTransform>();
                btn.anchoredPosition = new Vector2(0.0f, btn.anchoredPosition.y);
            }
        }
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OnRestart()
    {
        SceneManager.LoadScene(0);
    }
}
