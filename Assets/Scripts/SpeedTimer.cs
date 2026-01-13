using UnityEngine;

public class SpeedTimer : MonoBehaviour
{
    public float speed;
    float time = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;
    }
}
