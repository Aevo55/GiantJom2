using UnityEngine;

public class SelectableScript : MonoBehaviour
{

    public GameObject highlightRing;
    public GameObject selectionRing;
    public bool selected = false;

    public PlayerInputScript playerInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInput = GameObject.FindObjectsByType<PlayerInputScript>()[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        if(!selected)
        {
            highlightRing.SetActive(true);
            playerInput.highlighted = this;
        }
    }

    void OnMouseExit()
    {
        highlightRing.SetActive(false);
        playerInput.highlighted = null;
    }
}
