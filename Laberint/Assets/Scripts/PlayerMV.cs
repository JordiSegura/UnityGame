using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMV : MonoBehaviour
{
    public float speed = 1.0f;


    public float moveSpeed = 10f;
    // Update is called once per frame
    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        //Move
        Vector3 movement = new Vector3(moveX, 0f, moveZ);
        GetComponent<Rigidbody>().velocity = movement * moveSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);

            speed = speed * 2;
        }
        else
        {
            //porta.SetActive(false);
        }
    }
}
