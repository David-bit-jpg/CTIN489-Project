using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGameOnClick()
    {
        SceneManager.LoadScene("Level1");
    }
}
