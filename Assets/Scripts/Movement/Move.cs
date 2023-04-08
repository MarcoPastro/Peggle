using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float _MoveSpeed = 3f;


    public void ChangePosition(Vector3 position)
    {
        //transform.position = position * _MoveSpeed * Time.deltaTime + transform.position;
        //Vector2.Lerp can return poit between two vectors
        if (Time.deltaTime != 0)//to stop it when there is the pause menu
        {
            transform.position = Vector2.Lerp(transform.position, position, _MoveSpeed);//no Time.deltaTime to follow the pointer in real time
        }
    }
}
