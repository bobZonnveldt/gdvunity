using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotateobject : MonoBehaviour
{
     public float respawnTime = 3f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
       
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 1, 0*Time.deltaTime); 
        
    }
}
