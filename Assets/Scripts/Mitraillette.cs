using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mitraillette : MonoBehaviour
{
    [SerializeField]
     GameObject sphere;
    [SerializeField]
    float distanceJoueur;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))

        {
            Vector3 position = transform.position + Vector3.up * 1f + transform.forward * distanceJoueur;
            Instantiate(sphere, position, transform.rotation);

        }
    }  
}    

