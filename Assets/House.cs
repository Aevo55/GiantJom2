using UnityEngine;

public class House  : MonoBehaviour {

    private MeshFilter meshFilter;
    private Renderer meshRenderer;
        
    [SerializeField] private Mesh meshNormal;  
    [SerializeField] private Mesh meshDestroyed;  

    [SerializeField] private Material matNormal;
    [SerializeField] private Material matDestroyed;


    void Start()
    {
        meshFilter = GetComponent<MeshFilter>();
        meshRenderer = GetComponent<Renderer>();

        meshFilter.mesh = meshNormal;
        meshRenderer.material = matNormal;
    }

    void Destroyed ()
    {
        meshFilter.mesh = meshDestroyed;
        meshRenderer.material = matDestroyed;
    }
}

