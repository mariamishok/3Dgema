
using UnityEngine; 

public class DataTypes : MonoBehaviour
{
    //public это модификатор доступа если он приватный то доступ закрытый
    //типы данных нужен для обозначения вида данных или формата данных, которые будут хрониться
    //имя переменной нужен для обращения к переменной и для индефикации
    //"=" оператор нужен для присваивания значения в переменную, через этот оператор происходит инциолезация
    //значение это данные, которые присваиваются к переменной
    //Переменная может быть публичная или приватная с любым типом данных и со своим именим, может быть инициолезирована
    
    //public CubeTest cubeTest;
    //public GameObject myGameObject;
    //public Transform transCube;
    //public Material cubeMat;
    private string myText = "Hello World 124.32 % & &? -=+";
    public int Y = 1541;
    public float X = 15.5f;

    //Awake срабатывает один раз при включении игры, идет первым
    private void Awake()
    {
    }
    //  OnEnable срабатывает каждый раз при включении объекта на котором висит скрипт
    private void OnEnable()
    {
    }
    //  OnDisable срабатывает каждый раз при выключении объекта на котором висит скрипт
    private void OnDisable()
    {
    }
    //  OnDestroy срабатывает каждый раз при удалении объекта на котором висит скрипт
    private void OnDestroy()
    {
    }
    // start - это unity функция которая срабатывает ОДИН раз при старте игры за весь сеанс 
    private void Start()
    {
    }

    //  Update() это unity функция, которая запускается при старте игры и работает бесконечное количество времени пока игра не завершится 
    private void Update() // нужен для постоянного вызова чего либо, например для постоянного обновления каких либо данных
    {
    }
    private void LateUpdate()// всегда запускается после Update(), лучше всего использовать для расчета движения камеры
    {
    }
    private void FixedUpdate() // лучше всего использоваьб для обновления физических расчетов, например Collider, Rigidbody
    {
    }
    
    //эти фунции срабатывают при наличии этого скрипта на объекте
    //и при наличии компонента колайдер на объекте на котором висит этот скрипт
    private void OnMouseDown()
    {
        //cubeMat.color = Color.yellow;
    }
    private void OnMouseUp()
    {
        //cubeMat.color = Color.red;

    }
    private void OnMouseEnter()
    {
        //myGameObject.SetActive(true);
        //transCube.localScale = new Vector3(2, 2, 2);
        //cubeTest.gameObject.SetActive(true);
    }
    private void OnMouseExit()
    {
        //myGameObject.SetActive(false);
        //transCube.localScale = new Vector3(1, 1, 1);
        //cubeTest.gameObject.SetActive(false);
    }
    //необходимо наличие этого скрипта на объекте
    //и наличие компонентов на объекте на котором этот скрипт - Collider и Rigibody
    //и на объекте с которым происходит столкновение необходим компонент Collder
    private void OnCollisionEnter(Collision coll)
    {
        Debug.Log("Объект столкнулся");
    }
    private void OnCollisionStay(Collision coll)
    {
        Debug.Log("Объект контактирует");
    }
    private void OnCollisionExit(Collision coll)
    {
        Debug.Log("Объект перестал контактировать");
    }

    private void OnTriggerEnter(Collider cold)
    {
        
        if (cold.gameObject.tag == "Player")
        {
            Debug.Log("Объект вошел в зону триггера");
        }
    }
    private void OnTriggerStay(Collider cold)
    {
        
        if (cold.gameObject.tag == "Player")
        {
            Debug.Log("Объект находится в зоне триггера");
        }
    }
    private void OnTriggerExit(Collider cold)
    {
        
        if (cold.gameObject.tag == "Player")
        {
            Debug.Log("Объект вышел из зоны триггера");
        }
    }
    
}  