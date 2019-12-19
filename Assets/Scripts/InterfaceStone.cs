using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceStone : MonoBehaviour
{
    public Text textThrown;
    public Text textDestroy;
	public Text points;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        textThrown.text = "Number of Stones: " + GameManager.currentNumberStonesThrown;
        textDestroy.text = "Destroyed: " + GameManager.currentNumberDestroyedStones;
		points.text = "Points: " + GameManager.currentPoints;
    }
}
