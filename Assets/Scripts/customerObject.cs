using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerObject : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            Instantiate(objects[Random.Range(0, objects.Count)], transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
