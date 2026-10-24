using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    public SelectableScript[] selectables;
    public SelectableScript selectedObject;

    public SelectableScript highlighted;
    public MoveValidator highlightedMoveNode;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selectables = GameObject.FindObjectsByType<SelectableScript>();
        foreach(SelectableScript s in selectables)
        {
            s.playerInput = this;
        }
        foreach(MoveValidator m in GameObject.FindObjectsByType<MoveValidator>())
        {
            m.playerInput = this;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnAttack()
    {
        if(highlighted != null)
        {
            highlighted.select();
            selectedObject = highlighted;
        }
        else
        {
            if(highlightedMoveNode != null)
            {
                selectedObject.moveTarget = new Vector3(highlightedMoveNode.transform.position.x, selectedObject.transform.parent.position.y, highlightedMoveNode.transform.position.z);
                highlightedMoveNode.GetComponent<MeshRenderer>().enabled = true;
                highlightedMoveNode.GetComponent<BoxCollider>().enabled = true;
                highlightedMoveNode.what.gameObject.SetActive(false);
                highlightedMoveNode = null;
                
            }
            selectedObject?.deselect();
            selectedObject = null;
            
        }
    }
}
