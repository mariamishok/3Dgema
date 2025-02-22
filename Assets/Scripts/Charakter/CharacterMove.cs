using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 10;
    public float JumpForce = 4;
    private CameraCharacter cam;
    private Transform trCam;
    private Vector3 direc;
    private CharacterAnim anim;
    private bool IsCollision = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        cam = FindObjectOfType<CameraCharacter>();
        trCam = cam.GetComponent<Transform>();
        anim = GetComponent<CharacterAnim>();
    }

    
    private void FixedUpdate()
    {
        Vector3 inputAxis = InputAxis();
        Rotate(inputAxis);
        Moving(direc);
        anim.MoveAnim(inputAxis);

    }
    private void Update()
    {
        Jump(IsCollision);

    }
    private void OnCollisionEnter(Collision collision)
    {
        IsCollision = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        IsCollision = false;
    }
    private void Rotate(Vector3 inputAxis)
    {
        Vector3 dirFor = Vector3.ProjectOnPlane(trCam.forward, Vector3.up);
        Vector3 dirRight = Vector3.ProjectOnPlane(trCam.right, Vector3.up);
        direc = (inputAxis.z * dirFor) + (inputAxis.x * dirRight);
        Quaternion rote = Quaternion.LookRotation(dirFor, Vector3.up);
        rb.MoveRotation(rote);
    }
    private void Moving(Vector3 inputAxis)
    {
        speed = Input.GetKey(KeyCode.LeftShift) ? 8 : 3;
        rb.MovePosition(rb.position + inputAxis * speed * Time.deltaTime);

    }
    private Vector3 InputAxis()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        return new Vector3(x, 0, z);
    }
    private void Jump(bool IsCollision)
    {
        if (IsCollision && Input.GetKeyDown(KeyCode.Space))
        {
            anim.JumpAnim(true);
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
        else
        {
            anim.JumpAnim(false);
        }
    }
}
