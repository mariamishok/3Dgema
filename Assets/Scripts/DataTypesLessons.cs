
using UnityEngine; 

public class DataTypes : MonoBehaviour
{
    //public ��� ����������� ������� ���� �� ��������� �� ������ ��������
    //���� ������ ����� ��� ����������� ���� ������ ��� ������� ������, ������� ����� ���������
    //��� ���������� ����� ��� ��������� � ���������� � ��� �����������
    //"=" �������� ����� ��� ������������ �������� � ����������, ����� ���� �������� ���������� ������������
    //�������� ��� ������, ������� ������������� � ����������
    //���������� ����� ���� ��������� ��� ��������� � ����� ����� ������ � �� ����� ������, ����� ���� ����������������
    
    //public CubeTest cubeTest;
    //public GameObject myGameObject;
    //public Transform transCube;
    //public Material cubeMat;
    private string myText = "Hello World 124.32 % & &? -=+";
    public int Y = 1541;
    public float X = 15.5f;

    //Awake ����������� ���� ��� ��� ��������� ����, ���� ������
    private void Awake()
    {
    }
    //  OnEnable ����������� ������ ��� ��� ��������� ������� �� ������� ����� ������
    private void OnEnable()
    {
    }
    //  OnDisable ����������� ������ ��� ��� ���������� ������� �� ������� ����� ������
    private void OnDisable()
    {
    }
    //  OnDestroy ����������� ������ ��� ��� �������� ������� �� ������� ����� ������
    private void OnDestroy()
    {
    }
    // start - ��� unity ������� ������� ����������� ���� ��� ��� ������ ���� �� ���� ����� 
    private void Start()
    {
    }

    //  Update() ��� unity �������, ������� ����������� ��� ������ ���� � �������� ����������� ���������� ������� ���� ���� �� ���������� 
    private void Update() // ����� ��� ����������� ������ ���� ����, �������� ��� ����������� ���������� ����� ���� ������
    {
    }
    private void LateUpdate()// ������ ����������� ����� Update(), ����� ����� ������������ ��� ������� �������� ������
    {
    }
    private void FixedUpdate() // ����� ����� ������������ ��� ���������� ���������� ��������, �������� Collider, Rigidbody
    {
    }
    
    //��� ������ ����������� ��� ������� ����� ������� �� �������
    //� ��� ������� ���������� �������� �� ������� �� ������� ����� ���� ������
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
    //���������� ������� ����� ������� �� �������
    //� ������� ����������� �� ������� �� ������� ���� ������ - Collider � Rigibody
    //� �� ������� � ������� ���������� ������������ ��������� ��������� Collder
    private void OnCollisionEnter(Collision coll)
    {
        Debug.Log("������ ����������");
    }
    private void OnCollisionStay(Collision coll)
    {
        Debug.Log("������ ������������");
    }
    private void OnCollisionExit(Collision coll)
    {
        Debug.Log("������ �������� ��������������");
    }

    private void OnTriggerEnter(Collider cold)
    {
        
        if (cold.gameObject.tag == "Player")
        {
            Debug.Log("������ ����� � ���� ��������");
        }
    }
    private void OnTriggerStay(Collider cold)
    {
        
        if (cold.gameObject.tag == "Player")
        {
            Debug.Log("������ ��������� � ���� ��������");
        }
    }
    private void OnTriggerExit(Collider cold)
    {
        
        if (cold.gameObject.tag == "Player")
        {
            Debug.Log("������ ����� �� ���� ��������");
        }
    }
    
}  