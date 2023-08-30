using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public enum Emovement
{
    Forward,
    Backward,
    Left,
    Right
}

public class Vector3Examples : MonoBehaviour
{

    public float moveSpeed;
    public Emovement movementType;

    public Transform pointA, pointB;

    public float rangeValue;
    // Start is called before the first frame update
    void Start()
    {
        //Make the object go up
        //transform.position = Vector3.up;

        //make the object go left
        //transform.position = Vector3.left;
    }

    // Update is called once per frame
    void Update()
    {
        //switch (movementType)
        //{
        //    case Emovement.Forward:
        //        MoveForward();
        //        break;
        //    case Emovement.Backward:
        //        MoveBackward();
        //        break;
        //    case Emovement.Left:
        //        MoveLeft();
        //        break;
        //    case Emovement.Right:
        //        MoveRight();
        //        break;
        //    default:
        //        break;
        //}

        //Increases position values 1 per frame starting from 0
        //transform.position = Vector3.Lerp(pointA.position, pointB.position, moveSpeed * Time.time);

        //Increases the position quickly to 1 and after reaching the position "1" will go back to 0
        //transform.position = Vector3.Lerp(pointA.position, pointB.position, moveSpeed * Time.deltaTime);

        float dist = Vector3.Distance(transform.position, pointB.position);
        //Debug.Log(dist);

        if (dist <= rangeValue) 
        {
            Debug.Log("Point B has been detected!");
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangeValue);

    }

    public void MoveForward()
    {
        //make the object go forward
        transform.position = Vector3.forward * moveSpeed * Time.time;
    }

    public void MoveBackward()
    {
        //make the object go backward
        transform.position = Vector3.back * moveSpeed * Time.time;
    }

    public void MoveLeft()
    {
        //make the object go left
        transform.position = Vector3.left * moveSpeed * Time.time;
    }

    public void MoveRight()
    {
        //make the object go right
        transform.position = Vector3.right * moveSpeed * Time.time;
    }
}
