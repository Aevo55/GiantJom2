using UnityEngine;

public class MoveValidator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private RaycastHit hit;

    public Vector3 basePosition;
    public Vector3 hoverPosition;

    public Vector3 targetPosition;

    public PlayerInputScript playerInput;

    public redMoveScript what;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 downABit = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
        if(!Physics.Raycast(downABit, Vector3.down, out hit, 1f))
        {
           this.gameObject.SetActive(false);
        }
        Vector3 upABit = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        if(Physics.Raycast(transform.position, Vector3.up, out hit, 10f))
        {
            Debug.Log("HUH");
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            what.gameObject.SetActive(true);
        }
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, 5f * Time.deltaTime);
    }

    void OnMouseEnter()
    {
        targetPosition = hoverPosition;
        playerInput.highlightedMoveNode = this;
    }

    void OnMouseExit()
    {   
        targetPosition = basePosition;     
        playerInput.highlightedMoveNode = null;
    }
}
