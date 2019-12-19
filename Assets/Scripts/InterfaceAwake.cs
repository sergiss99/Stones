using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceAwake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameManager.currentNumberStonesThrown = 0;
        GameManager.currentNumberDestroyedStones = 0;
        GameManager.currentPoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        Application.LoadLevel("stoneGame");
    } 
}
