using UnityEngine;
using UnityEngine.UI;

public class MainMenuPage : MonoBehaviour
{
    public Button startButton;
    public Button quitButton;
    
    void Start()
    {
        if (startButton != null)
        {
            startButton.onClick.AddListener(StartGame);
        }
        
        if (quitButton != null)
        {
            quitButton.onClick.AddListener(QuitGame);
        }
    }
    
    void StartGame()
    {
        Debug.Log("Start Game button pressed");
    }
    
    void QuitGame()
    {
        Debug.Log("Quit Game button pressed");
        Application.Quit();
    }

    void Update()
    {

Cursor.lockState = CursorLockMode.None;
Cursor.visible = true;

}


    }
 