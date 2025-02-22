using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCharacter : MonoBehaviour
{
    private Transform trsCam;
    public Transform trsChar;
    private Vector3 offset;
    private float x;
    private float y;
    public float sesitivity = 50;
    
    private void Awake()
    {
        trsCam  = GetComponent <Transform>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        offset = trsCam.position - trsChar.position;
    }
    private void LateUpdate()
    {
        Vector3 inputAxis = InputAxis();
        RotateCamera(inputAxis);
        Follow();
    }
    private Vector3 InputAxis()
    {
         x += Input.GetAxis("Mouse X") * sesitivity * Time.deltaTime;
         y -= Input.GetAxis("Mouse Y") * sesitivity * Time.deltaTime;
        return new Vector3(y, x, 0);
        
    }
    private void RotateCamera(Vector3 inputAxis)
    {
        trsCam.localEulerAngles = inputAxis;
        
    }
    private void Follow()
    {
        trsCam.position = trsCam.localRotation * offset + trsChar.position;
    }
}
