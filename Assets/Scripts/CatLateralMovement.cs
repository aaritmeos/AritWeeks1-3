using UnityEngine;
using UnityEngine.InputSystem;

public class CatLateralMovement : MonoBehaviour
    
{
    //created float height to personalize height of the cat in the screen
    public float height;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //create Vector that allows us to modify the values of the transform
        Vector2 catPos = transform.position;

        //create vector to store mouse position in game world
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

        //assign the x value of the mouse to the x value in the transform of the Game Object
        catPos.x = mousePos.x;
        //assigned y of new Pos to height to change it from the inspector
        catPos.y = height;

        //reassign mousePos to the transform
        transform.position = catPos;
        
    }
}
