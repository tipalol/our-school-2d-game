using UnityEngine;

public class Patrol : MonoBehaviour
{
    //Ссылка на самого себя, перетаскивается в редакторе Юнити
    public Transform Self;
    //Ссылка на свой компонент, с помощью которого мы поворачиваем спрайт вправо/влево (в нашем случае)
    public SpriteRenderer Renderer;

    //Список точек, по которым последовательно и циклично будет двигаться объект
    public Transform[] Points;

    //Номер в списке той точки, к которой идем сейчас
    private int _target;

    //Выполняется один раз на старте
    void Start()
    {
        //Говорим, что сейчас идем к самой первой точке (нумерация начинается с нуля)
        _target = 0;
        //Разворачиваемся вправо (зависит от конкретного спрайта)
        Renderer.flipX = true;
    }

    //Выполняется каждый кадр
    void Update()
    {
        //Если достигли нужной позиции
        if (Self.position.x == Points[_target].position.x) 
        {
            //Если смотрели вправо
            if (Renderer.flipX == true)
                //Поворачиваемся налево
                Renderer.flipX = false;
            //Иначе
            else
                //Поворачиваемся направо
                Renderer.flipX = true;

            //Увеличиваем номер текущей цели-точки,
            //если достигли конца списка - устанавливаем номер на 0, то есть на первый элемент
            if (++_target > 1)
                _target = 0;
        }

        //Смещаемся в сторону цели
        Self.position = Vector2.MoveTowards(Self.position, Points[_target].position, Time.deltaTime * 2);
    }
}
