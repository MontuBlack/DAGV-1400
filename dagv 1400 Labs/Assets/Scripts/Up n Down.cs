using UnityEngine;

public class UpnDown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, Mathf.Sin(Time.time) * Time.deltaTime, 0f, Space.World);
        
    }
}
