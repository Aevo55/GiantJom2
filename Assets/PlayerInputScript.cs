using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputScript : MonoBehaviour
{
    public SelectableScript[] selectables;
    public SelectableScript selectedObject;

    public SelectableScript highlighted;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        selectables = GameObject.FindObjectsByType<SelectableScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnAttack()
    {
        if(highlighted != null)
        {
            highlighted.selected = true;
            highlighted.selectionRing.SetActive(true);
            selectedObject = highlighted;
        }
        else
        {
            selectedObject.selectionRing.SetActive(false);
            selectedObject.selected = false;    
            selectedObject = null;
            
        }
    }
}
