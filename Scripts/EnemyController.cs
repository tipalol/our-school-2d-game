using UnityEngine;
using UnityEngine.Events;

public class EnemyController : MonoBehaviour
{
    //Событие - враг задел игрока, в Юнити добавляем действия
    public UnityEvent OnPlayerTouched;

    //Если с кем-то столкнулись
    void OnCollisionEnter2D(Collision2D collision) 
    {
        //Если этот кто-то - игрок
        if (collision.collider.name == "Player")
        {
            //Если игрок прыгнул на нас сверху
            if (collision.otherCollider.transform.position.y - collision.transform.position.y <= -1f)
                //Уничтожаем себя
                GameObject.Destroy(gameObject);
            //Иначе
            else
                //Запускаем все действия, прикрепленные в редакторе Юнити
                OnPlayerTouched?.Invoke();
        }
    }
}
