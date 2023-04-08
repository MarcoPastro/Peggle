using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Cannon : MonoBehaviour
{
    public Rigidbody2D RigidbodyBall;
    public Move Pointer;
    private Vector3 _direction;
    [SerializeField]
    private float _MoveForce;

    private bool _canShot;

    void Start()
    {
        _canShot = true;
    }

    // Update is called once per frame
    void Update()
    {
        RotateToPoiter();
    }
    private void RotateToPoiter()
    {
        _direction = Pointer.transform.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, _direction);
    }

    public void Shot()
    {
        if (_canShot)
        {
            RigidbodyBall.gameObject.SetActive(true);
            RigidbodyBall.AddForce(_direction * _MoveForce);
            _canShot = false;
        }
    }

    public void ResetBall()
    {
        
        RigidbodyBall.gameObject.SetActive(false);
        RigidbodyBall.gameObject.transform.position = gameObject.transform.position;
        _canShot = true;
    }
}
