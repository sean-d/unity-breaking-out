using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    // Configuration Stuff
    // screenWidthUnits: how wide the screen is in unity units. Aspect ratio is 4:3. The camera is size 6 which makes the screen 12 tall. in 4:3, the width becomes 16.
    // minPaddleX: the farthest to the left the paddle can move. Set to 1 so it touches the side.
    // maxPaddleX: the farthest to the right the paddle can move. Set to 15 so it touches the side.
    private float screenWidthUnits = 16.0f;
    private float minPaddleXPos = 0.86f;
    private float maxPaddleXPos = 15.15f;

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
