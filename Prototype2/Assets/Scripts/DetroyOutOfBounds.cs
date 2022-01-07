using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetroyOutOfBounds : MonoBehaviour
{

    private float upperBound = 30.0f;
    private float lowerBound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if object goes past the player's view, remove that object
        if (transform.position.z > upperBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound) {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
