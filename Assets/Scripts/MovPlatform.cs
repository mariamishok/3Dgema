using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlatform : MonoBehaviour
{
    public float speedMove = 3;
    public Transform platTransform;
    public float maxDistance = 10;
    public float minDistance = 0;
    public bool isRight = true;
    public bool isLeft = false;
 

    

    private void Update()
    {
        if (isLeft == true)
        {
            MoveLeft();
        }
        else if(isRight == true)
        {
            MoveRight();
        }
        
    }
    private void MoveLeft()
    {
        if(platTransform.position.x > minDistance)
        {
            isLeft = true;
            platTransform.position += Vector3.left * Time.deltaTime * speedMove;
        }
        else
        {
            isRight = true;
            isLeft = false;
        }
    }
    private void MoveRight()
    {
        if(platTransform.position.x <= maxDistance)
        {
            isRight = true;
            platTransform.position += Vector3.right * Time.deltaTime * speedMove;
        }
        else
        {
            isRight = false;
            isLeft = true;
        }

    }
}
