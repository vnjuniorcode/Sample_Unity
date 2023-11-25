
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class BallMove : MonoBehaviour
{
    private Rigidbody ball;
    
    [SerializeField] private float powerImpulse = 80f;
    
    void Start()
    {
        ball = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        Debug.Log("You"+" are cool!");
    }
    
    public void MoveUp()
    {
        ball.AddForce(Vector3.forward * powerImpulse);
    }
    
    public void MoveDown()
    {
        ball.AddForce(-Vector3.forward * powerImpulse);
    }
    
    public void MoveLeft()
    {
        ball.AddForce(Vector3.left * powerImpulse);
    }
    
    public void MoveRight()
    {
        ball.AddForce(-Vector3.left * powerImpulse);
    }
}
