using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("Algo pas�");
        Debug.Log("algo pas�");
        Debug.LogWarning("Algo medianamente malo pas�");
        Debug.LogError("Algo sali� muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
