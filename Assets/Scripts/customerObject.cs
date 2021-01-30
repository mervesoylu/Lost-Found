using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customerObject : MonoBehaviour
{
    public customerObjectsList list;
    public GameObject ob;




    // Start is called before the first frame update
    void Start()
    {
        
        for (var i = 0; i < 1; i++)
        {
            ob = Instantiate(list.objects[Random.Range(0, list.objects.Count)], transform.position, Quaternion.identity, transform.parent);
        }
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == ob.tag)
                {
                    Debug.Log("Right");
                }
                if (hitInfo.collider.gameObject.tag != ob.tag)
                {
                    Debug.Log("Wrong");
                }
            }
        }
    }




}
