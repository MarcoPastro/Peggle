using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeMap : MonoBehaviour
{
    public Cannon Cannon;
    public GameController Controller;
    [SerializeField]
    private bool _IsAMap=true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Ball>()!=null)
        {
            Cannon.ResetBall();
            if(_IsAMap) Controller.DeleteHit();
        }
    }
}
