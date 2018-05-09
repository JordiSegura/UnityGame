using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp : MonoBehaviour
{
    public GameObject obj;

     void OnTriggerEnter(Collider other)
    {
        other.transform.position = obj.transform.position;
    }
}
