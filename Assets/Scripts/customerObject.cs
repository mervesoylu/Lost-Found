using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class customerObject : MonoBehaviour
{
    public customerObjectsList list;
    public GameObject ob;
    public lives hearts;




    // Start is called before the first frame update
    void Start()
    {
        
        for (var i = 0; i < 1; i++)
        {
            ob = Instantiate(list.objects[Random.Range(0, list.objects.Count)], transform.position, Quaternion.identity);
        }
    }

    public void Update()
    {
        Destroy(ob, 10);
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                if (hitInfo.collider.gameObject.tag == ob.tag)
                {
                    Debug.Log("Right");


                    Destroy(ob);
                }
                if (hitInfo.collider.gameObject.tag != ob.tag)
                {
                    Debug.Log("Wrong");

                    hearts.liveCount[0].SetActive(false);
                    Destroy(ob);

                }
                
            }
        }

        if (ob == false)
        {
            ob = Instantiate(list.objects[Random.Range(0, list.objects.Count)], transform.position, Quaternion.identity);
        }
    }




}
