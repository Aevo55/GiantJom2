using UnityEngine;

public class TileSpawnerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public bool started = false;
    private float speed = 30f;

    private Vector3 loc;
    void Start()
    {
        loc = this.transform.position;
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(started)
        {
            transform.position = Vector3.MoveTowards(transform.position, loc, speed * Time.deltaTime);
        }
    }

    public void Spawn()
    {
        started = true;
    }
}
