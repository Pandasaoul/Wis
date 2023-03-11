using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuExit : MonoBehaviour
{
    public void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
