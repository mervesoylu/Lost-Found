using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerObject : MonoBehaviour
{
    public customerObjectsList list;

    // Start is called before the first frame update
    void Start()
    {
        
        for (var i = 0; i < 1; i++)
        {
            Instantiate(list.objects[Random.Range(0, list.objects.Count)], transform.position, Quaternion.identity, transform.parent);
        }
    }

    
}
