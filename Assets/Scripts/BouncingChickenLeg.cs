using UnityEngine;

public class BouncingChickenLeg : MonoBehaviour
{
    //create vectors to determine size of the screen
    Vector2 leftBorder;
    Vector2 rightBorder;
    //create float to modify speed of movement of the object
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //assign the values of the borders of  the screen to the vectors
        leftBorder = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        rightBorder = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        //create vector to modify the transform
        Vector3 legPos = transform.position;
        //modified x position using the speed variable and time.deltatime to prevent the sprite from bugging at the edge of the screen
        legPos.x += speed * Time.deltaTime;
        
        
        //used vector2 to translate world position to screen position
        Vector2 screenLength = Camera.main.WorldToScreenPoint(transform.position);

        //test if the object is at the left border
        if (screenLength.x < 0)
        {
            //set position back inside screen
            legPos.x = leftBorder.x;
            //invert speed
            speed = speed * -1;
        }
            
        //test if the object is at the right border
        if (screenLength.x > Screen.width)
        {
            //set position back insisde the screen
            legPos.x = rightBorder.x;

            //invert the speed
            speed = speed * -1;
        }

        //returned modified position to the transform
        transform.position = legPos;
    }

    //Kit’s Dev Log. (2026, January 4). 2-4 time [Video]. YouTube. https://www.youtube.com/watch?v=aIkF826iMNs
}
