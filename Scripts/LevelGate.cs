//Подключаем стандартную библиотеку Юнити
using UnityEngine;
//Подключаем пространство имен для работы со сценами
using UnityEngine.SceneManagement;

public class LevelGate : MonoBehaviour
{
    //Имя сцены, задается в редакторе Юнити в настройках этого компонента
    public string SceneName;

    //Если кто-то столкнулся с нами
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //Если этот кто-то - игрок
        if (collision.name == "Player")
            //Грузим указанную сцену
            SceneManager.LoadScene(SceneName);
    }
}
