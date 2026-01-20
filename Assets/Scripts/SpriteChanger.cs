using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         //PickARandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.anyKey.wasPressedThisFrame)
        //{
        //    PickARandomColor();
        //}

        // NOT THIS: spriteRenderer.sprite.bounds.Contains()


        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToViewportPoint(Mouse.current.position.ReadValue());
        // is it over the shape
        if(spriteRenderer.bounds.Contains(mousePos) == true)
        {
            //Y: set the color with our color varible
            spriteRenderer.color = col;
        }
        else
        {
            //N: set th color to white
            spriteRenderer.color = Color.white;
        }

    }

    void PickARandomColor ()
    {
        spriteRenderer.color = Random.ColorHSV();
    }
}
