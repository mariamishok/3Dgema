using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform2 : MonoBehaviour
{
    public float speedNew = 3;
    public Transform platTransform;
    public float maxHeight = 10;
    public float minHeight = 0;
    public bool isUp = true;
    public bool isDown = false;

    private void Update()
    {
        if (isDown == true)
        {
            MoveDown();
        }
        else if (isUp == true)
        {
            MoveUp();
        }

    }
    private void MoveDown()
    {
        if (platTransform.position.y > minHeight)
        {
            isDown = true;
            platTransform.position += Vector3.down * Time.deltaTime * speedNew;
        }
        else
        {
            isUp = true;
            isDown = false;
        }
    }

    private void MoveUp()
    {
        if (platTransform.position.y < maxHeight)
        {
            isUp = true;
            platTransform.position += Vector3.up * Time.deltaTime * speedNew;
        }
        else
        {
            isUp = false;
            isDown = true;
        }
    }

}