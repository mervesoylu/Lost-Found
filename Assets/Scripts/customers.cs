﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customers : MonoBehaviour
{
    public customerList list;

    public GameObject cus;



    void Start()
    {

        for (var i = 0; i < 1; i++)
        {
           cus = Instantiate(list.customers[Random.Range(0, list.customers.Count)], transform.position, Quaternion.identity);

           cus.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        //StartCoroutine(WaitInstantiate());
    }


    //public void Update()
    //{
    //    if (cus == false)
    //    {
    //        for (var i = 0; i < 1; i++)
    //        {
    //            cus = Instantiate(list.customers[Random.Range(0, list.customers.Count)], transform.position, Quaternion.identity);

    //            cus.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    //        }

    //        StartCoroutine(WaitInstantiate());
    //    }

    //IEnumerator WaitInstantiate()
    //{
    //    yield return new WaitForSeconds(10);

    //    Object.Destroy(cus);

    //    for (var i = 0; i < 1; i++)
    //    {
    //        cus = Instantiate(list.customers[Random.Range(0, list.customers.Count)], transform.position, Quaternion.identity);

    //        cus.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

    //    }

    //    StartCoroutine(WaitInstantiate());

    //}

    
}
