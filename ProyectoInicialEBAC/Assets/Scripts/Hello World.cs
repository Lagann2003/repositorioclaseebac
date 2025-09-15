using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int x;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        x = 0;
     
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log(x);

        Debug.Log("Hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogError("Hola desde Fixed Update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El Objeto ha sido Habilitado");
    }

    private void OnDisable()
    {
        Debug.Log("el objeto ha sido inhabilitado");
    }
}
