using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Получаем ссылку на панель магазина (прикрепляем в Юнити)
    public GameObject StorePanel;

    //Этот метод мы используем при нажатии на кнопку выход
    public void Exit() 
    {
        //Выходит из игры (работает только в билде, не в редакторе)
        Application.Quit(0);
    }

    //Этот метод мы используем при нажатии на кнопку играть
    public void Play() 
    {
        //Загружает сцену с названием Level 1
        //(сцена должна присутствовать в списке сцен в build settings)
        SceneManager.LoadScene("Level 1");
    }

    //Этот метод мы используем при нажатии на кнопку Настройки
    public void Settings() 
    {
        //Выводим в консоль Юнити сообщение
        Debug.Log("Зашли в настройки");
    }

    //Этот метод мы используем при нажатии на кнопку Магазина
    public void Store() 
    {
        //Включаем объект панели магазина
        StorePanel.SetActive(true);
    }

    //Этот метод мы используем при нажатии на кнпоку закрытия магазина
    public void CloseStore() 
    {
        //Отключаем объект панели магазина
        StorePanel.SetActive(false);
    }
}
