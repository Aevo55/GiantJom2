using UnityEngine;

public class House  : MonoBehaviour {

    public GameObject meshNormal;  
    public GameObject meshDestroyed;  

    void Start()
    {
        meshNormal.SetActive(true);
        meshDestroyed.SetActive(false);
    }

    void Destroyed ()
    {
        meshDestroyed.SetActive(true);
        meshNormal.SetActive(false);
    }
}

