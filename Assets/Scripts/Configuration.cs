using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configuration : MonoBehaviour
{
    public GameObject trunk;
    public float basePosition;
    public int initialQuantity;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < initialQuantity; i++)
        {        
            GameObject currentTrunk = Instantiate(trunk, new Vector2(0f, basePosition), transform.rotation);

            currentTrunk.transform.position = new Vector2(currentTrunk.transform.position.x, 
                transform.position.y + basePosition);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
