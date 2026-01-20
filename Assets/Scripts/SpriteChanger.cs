using NUnit.Framework;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Color col;
    public List<Sprite> barrels;
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         //PickARandomColor();
         PickARandomSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame)
        {
            Debug.Log("Try to change the sprite please");
            //PickARandomColor();
            if (barrels.Count > 0)
            {
                PickARandomSprite();
            }
        }

        // NOT THIS: spriteRenderer.sprite.bounds.Contains()


        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
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

        if(Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0)
        {
            barrels.RemoveAt(0);
        }
    }

    void PickARandomColor ()
    {
        spriteRenderer.color = Random.ColorHSV();
    }

    void PickARandomSprite()
    {
        //spriteRenderer.sprite = mySprite;

        //pick a random number
        randomNumber = Random.Range(0, barrels.Count);
        //use that number to chose a sprite
        //assign that sprite to the sprite renderer
        spriteRenderer.sprite = barrels[randomNumber];
    }
}
