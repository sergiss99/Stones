using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceFinal : MonoBehaviour
{
    public Text textThrown;

    public Text textDestroyed;
    public Text points;

    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.currentNumberDestroyedStones > 10)
        {
            GameManager.currentPoints = GameManager.currentPoints + 800;

        }
        else
        {
            GameManager.currentPoints = GameManager.currentPoints + 100;

        }
    }

    // Update is called once per frame
    void Update(){
    
		
        textThrown.text = "Number of Stones: " + GameManager.currentNumberStonesThrown;
        textDestroyed.text = "Destroyed: " + GameManager.currentNumberDestroyedStones;
        points.text = "Points : " + GameManager.currentPoints;

    }

    public void Clik()
    {
        Application.LoadLevel("Awake");

    }
}
