using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject gameOver;
    public GameObject pauseMenuUI;
    bool isActive = false;

    bool isPressed = false;
    void Start ()
    {
        pauseMenuUI.SetActive(false);
    }
    void Update()
    {
        bool Ispressed = Input.GetKeyDown(KeyCode.Escape);
        if (Ispressed && isActive && !isPressed)
        {
            Resume();
        }
        else if (Ispressed && !isActive && !isPressed)
        {
            Pause();
        }
        isPressed = Ispressed;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        isActive = false;
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        gameOver.SetActive(false);
        isActive = true;
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void ExitGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("1Menu");
    }
}
