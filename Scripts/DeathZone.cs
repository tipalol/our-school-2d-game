//Подключаем стандартную библиотеку Юнити
using UnityEngine;
//Подключаем пространство имен для работы с событиями
using UnityEngine.Events;

public class DeathZone : MonoBehaviour
{
    //Событие - игрок вошел в зону смерти
    public UnityEvent OnPlayerEnter;

    //Если кто-то вошел в зону
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //Если этот кто-то - игрок
        if (collision.name == "Player")
            //Запускаем все прикрепленные в редакторе действия
            OnPlayerEnter?.Invoke();
    }
}
