 
using UnityEngine;

public class CubeTest : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("CubeTest был включен и сработал OnEnable");  
    }
    private void OnDisable()
    {
        Debug.Log("CubeTest был выключен и сработал OnDisable"); 
    }
}

