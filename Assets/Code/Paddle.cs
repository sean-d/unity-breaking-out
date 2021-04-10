using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthUnits = 16f;
    private float minPaddleXPos = 0f;
    private float maxPaddleXPos = 16f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get current location of X coord for the platform
        // create a new paddle position vector2 object that has the current x/y of the paddle
        // update the x coord of the paddle with current X position in step 1 and only allow it to be 0->16 so it does not go off-screen
        float currentXPos = Input.mousePosition.x / Screen.width * screenWidthUnits;
        Vector2 PaddlePos = new Vector2(Input.mousePosition.x, transform.position.y);
        PaddlePos.x = Mathf.Clamp(currentXPos, minPaddleXPos, maxPaddleXPos);
        transform.position = PaddlePos;
    }
}
