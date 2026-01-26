using UnityEngine;

public class ChubbyBart : MonoBehaviour
{
    //create public trasnforms to determine start and final position of the cat
    public Transform left;
    public Transform right;
    //variable to measure time
    public float t;
    //curve to modify the route and size of the cat
    public AnimationCurve curve;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer
        t += Time.deltaTime;

        //reset timer
        if (t > 1)
        {
            t = 0;
        }

        //set track of the cat using the curve in the inspector
        transform.position = Vector2.Lerp(left.position, right.position, curve.Evaluate(t));
    }
    //Kit’s Dev Log. (2026b, January 4). 2-5 linear interpolation [Video]. YouTube. https://www.youtube.com/watch?v=hTmuDJX1pr4
}
