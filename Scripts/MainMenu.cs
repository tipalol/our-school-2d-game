using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject StorePanel;

    public void Exit() 
    {
        Application.Quit(0);
    }

    public void Play() 
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Settings() 
    {
        Debug.Log("Зашли в настройки");
    }

    public void Store() 
    {
        StorePanel.SetActive(true);
    }

    public void CloseStore() 
    {
        StorePanel.SetActive(false);
    }
}
