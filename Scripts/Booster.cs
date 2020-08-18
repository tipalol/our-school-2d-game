//Подключаем стандартную библиотеку Юнити
using UnityEngine;
//Подключаем пространство имен для работы с событиями
using UnityEngine.Events;

public class Booster : MonoBehaviour
{
    //Событие - игрок коснулся нас
    public UnityEvent OnPlayerEnter;

    //Если кто-то касается нас
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //Если этот кто-то - игрок
        if (collision.name == "Player")
            //То запускаем все прикрепленные в редакторе Юнити действия
            OnPlayerEnter?.Invoke();
    }
}
