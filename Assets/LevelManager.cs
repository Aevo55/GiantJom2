using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public GameObject Goal;
    public GameObject WinText;

    void Start()
    {
        WinText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Goal.activeSelf == true) {
            WinText.SetActive(true);
        }
    }
}
