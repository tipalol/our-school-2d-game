//Подключаем стандартную библиотеку Юнити
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Получаем компоненты игрока из Юнити (перетащив их в редакторе Юнити в соответствующие поля объекта)
    public Transform Self;
    public Rigidbody2D RigidBody;
    public SpriteRenderer Renderer;
    public BoxCollider2D Collider;

    //Слой земли - выбираем так же в списке в самом редакторе
    public LayerMask GroundLayer;

    //Объявляем поле скорость, позволяющее менять скорость из редактора Юнити
    public float Speed;
    
    //Получаем компонент Transform точки респавна для определения ее позиции
    public Transform RespawnPoint;

    //Метод, срабатывающий аналогично прыжку, но в 2 раза сильнее
    public void Boost() 
    {
        //Прикладываем к игроку силу, толкающую наверх
        RigidBody.AddForce(Vector2.up * 20, ForceMode2D.Impulse);
    }

    //Метод, возвращающий игрока в точку респауна
    public void Respawn()
    {
        Self.position = RespawnPoint.position;
    }

    //Вызывается каждый кадр
    private void Update()
    {
        //Если нажата D
        if (Input.GetKey(KeyCode.D))
        {
            //Переменащемся на 1 вправо * скорость
            Self.Translate(Vector2.right * Speed);
            //Поварачиваемся вправо (зависит от конкретного спрайта)
            Renderer.flipX = false;
        }

        //Аналогично коду выше, но влево
        if (Input.GetKey(KeyCode.A))
        {
            Self.Translate(Vector2.left * Speed);
            Renderer.flipX = true;
        }

        //Если нажали на пробел
        if (Input.GetKeyDown(KeyCode.Space)) {
            //Если стоим на земле
            if (IsGrounded())
                //Прикладываем к игроку силу, толкающую наверх
                RigidBody.AddForce(Vector2.up * 10, ForceMode2D.Impulse);    
        }
    }

    //Проверяет, стоим ли мы на земле
    private bool IsGrounded() 
    {
        //Насколько ниже нашего колайдера проверяем
        float extraHeight = 1f;
        //Создаем невидимый квадрат вокруг нашего персонажа и чуть ниже
        RaycastHit2D hit = Physics2D.BoxCast(Collider.bounds.center, Collider.bounds.size, 0f, Vector2.down, extraHeight, GroundLayer);

        //Если квадрат столкнулся с землей, то возвращаем правду (true), иначе ложь (false)
        return hit.collider != null;
    }
    
}
