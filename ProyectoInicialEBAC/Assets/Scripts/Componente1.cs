using UnityEngine;

public class Componente1 : MonoBehaviour
{
    private void Awake()
    {
        
    }
    public static GameObject MiObjeto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MiObjeto = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
