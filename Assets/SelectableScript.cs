using UnityEngine;

public class SelectableScript : MonoBehaviour
{

    public GameObject highlightRing;
    public GameObject selectionRing;
    public bool selected = false;

    public GameObject moveNodes;

    public PlayerInputScript playerInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInput = GameObject.FindObjectsByType<PlayerInputScript>()[0];
        foreach(Transform t in moveNodes.transform)
        {
            t.GetComponent<MoveValidator>().basePosition = t.position;
            t.GetComponent<MoveValidator>().hoverPosition = new Vector3(t.position.x, t.position.y + 0.1f, t.position.z);
            t.GetComponent<MoveValidator>().targetPosition = t.position;
            t.gameObject.SetActive(false);
        }
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

    public void select()
    {
        selected = true;
        selectionRing.SetActive(true);
        highlightRing.SetActive(false);
        foreach(Transform t in moveNodes.transform)
        {
            t.gameObject.SetActive(true);
        }
    }

    public void deselect()
    {
        selected = false;
        selectionRing.SetActive(false);
        foreach(Transform t in moveNodes.transform)
        {
            t.gameObject.SetActive(false);
        }
    }
}
