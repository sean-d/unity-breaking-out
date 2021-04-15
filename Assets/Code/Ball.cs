using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Config Stuff
    // We will create a paddle instance from the main paddle class called mainPaddle. This way we can have additional paddles if we want. 
    [SerializeField] Paddle mainPaddle;

    // State Stuff
    // paddleToBallVector used to determine and inform distance between the paddle and the ball.
    Vector2 paddleToBallVector;
    Rigidbody2D myRigidBody2D;
    bool started = false;

    // Start is called before the first frame update
    void Start()
    {
        // difference between the ball and the paddle transforms will yield a vector2.
        paddleToBallVector = transform.position - mainPaddle.transform.position;
        myRigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            LockBallToPaddle(); 
            ShootBallOnClick();           
        }

    }

    private void LockBallToPaddle()
    {
        Vector2 currentPaddlePos = new Vector2(mainPaddle.transform.position.x, mainPaddle.transform.position.y);
        transform.position = paddleToBallVector + currentPaddlePos;
    }

    private void ShootBallOnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            started = true;
            myRigidBody2D.velocity = new Vector2(0f, 8f);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {

        Vector2 TempVector = new Vector2(0.1f, .1f);
        if (started)
        {
            myRigidBody2D.velocity += TempVector;
        }
    }
}
