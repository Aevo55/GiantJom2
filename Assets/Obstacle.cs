using UnityEngine;

public class Obstacle : MonoBehaviour {
    public bool isHighground;
    public bool isDestructable;

    void cragonHits(){
        if(isDestructable) {
            Destroy(this);
        }
    }

    void drabFliesOver() {
        if(isHighground) {
            //todo: dont let it do that 
        }
    }
}