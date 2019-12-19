using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{

    public GameObject explosion;
    
    private const float yDie = -30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yDie)
        {
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
		if(gameObject.tag == "Asteroid500"){
			GameManager.currentPoints = GameManager.currentPoints + 500;
		}else if(gameObject.tag == "Asteroid700"){
			GameManager.currentPoints = GameManager.currentPoints + 700;
		}else if(gameObject.tag == "Asteroid1000"){
			GameManager.currentPoints = GameManager.currentPoints + 1000;
		}else if(gameObject.tag == "Police"){
			GameManager.currentPoints = GameManager.currentPoints - 800;
		}
        Destroy(gameObject);
        GameManager.currentNumberDestroyedStones++;
    }

}
