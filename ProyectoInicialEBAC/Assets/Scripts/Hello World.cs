using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Algo pasó");
        Debug.Log("algo pasó");
        Debug.LogWarning("Algo medianamente malo pasó");
        Debug.LogError("Algo salió muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
