using UnityEngine;

public class Bouncy : MonoBehaviour
{
    float speedX = 0.01f;
    float speedY = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = transform.position;
        newPos.x += speedX;
        newPos.y += speedY;
        transform.position = newPos;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speedX = speedX * -1;
        }

        if (screenPos.y < 0 || screenPos.y > Screen.height)
        {
            speedY = speedY * -1;
        }
    }
}
