using UnityEngine;

public class TileSpawnerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public bool started = false;
    public bool falling = false;
    private float speed = 30f;

    public Vector3 loc;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(started)
        {
            transform.position = Vector3.MoveTowards(transform.position, loc, speed * Time.deltaTime);
        }
        
        if(falling) {
            transform.position = Vector3.MoveTowards(transform.position, Vector3.down, speed * Time.deltaTime);
        }
    }

    public void Spawn()
    {
        started = true;
    }

    public void isFalling(bool isFalling) {
        falling = isFalling;
    }
}
