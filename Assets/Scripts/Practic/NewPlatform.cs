using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlatform : MonoBehaviour
{
    public float speedNew = 3;
    public Transform platTransform;
    public float maxDistance = 10;
    public float minDistance = 0;
    public bool isBack = true;
    public bool isForward = false;

    private void Update()
    {
        if (isForward == true)
        {
            NewForward();
        }
        else if (isBack == true)
        {
            NewBack();
        }

    }
    private void NewForward()
    {
        if (platTransform.position.z <= maxDistance)
        {
            isForward = true;
            platTransform.position += Vector3.forward * Time.deltaTime * speedNew;
        }
        else
        {
            isBack = true;
            isForward = false;
        }
    }

    private void NewBack()
    {
        if (platTransform.position.z >= minDistance)
        {
            isBack = true;
            platTransform.position += Vector3.back * Time.deltaTime * speedNew;
        }
        else
        {
            isBack = false;
            isForward = true;
        }
    }
}
