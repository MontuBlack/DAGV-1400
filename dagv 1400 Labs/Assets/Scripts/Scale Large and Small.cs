using UnityEngine;

public class ScaleLargeandSmall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(1f + Mathf.Sin(Time.time) * 0.5f, 1f + Mathf.Sin(Time.time) * 0.5f, 1f + Mathf.Sin(Time.time) * 0.5f);
    }
}
