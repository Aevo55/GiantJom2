using UnityEngine;

public class SelectableScript : MonoBehaviour
{

    public GameObject highlightRing;
    public GameObject selectionRing;
    public bool selected = false;

    public GameObject moveNodes;

    public PlayerInputScript playerInput;

    public Vector3 moveTarget;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveTarget = this.transform.parent.position;
        playerInput = GameObject.FindObjectsByType<PlayerInputScript>()[0];
        foreach(Transform t in moveNodes.transform)
        {
                t.GetComponent<MoveValidator>().basePosition = t.localPosition;
                t.GetComponent<MoveValidator>().hoverPosition = new Vector3(t.localPosition.x, t.localPosition.y + 0.1f, t.localPosition.z);
                t.GetComponent<MoveValidator>().targetPosition = t.localPosition;
            t.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (moveTarget != null)
        {
            transform.parent.position = Vector3.MoveTowards(transform.parent.position, moveTarget, 5f * Time.deltaTime);
        }
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
