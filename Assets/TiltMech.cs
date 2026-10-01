using UnityEngine;
using UnityEngine.UIElements;

public class TiltMech : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed = 0.1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Vertical") * speed;
        float yAxis = Input.GetAxis("Horizontal") * -speed;
        transform.Rotate(xAxis, 0, yAxis);
    }
}