using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MvmtBoule : MonoBehaviour
    
   
    
{
    [SerializeField]
    GameObject sphere;

    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
   

    // Update is called once per frame
    void FixedUpdate()
    {
        float speed = 8f;
        Vector3 direction = transform.forward;
        Vector3 currentPosition = transform.position;
        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;
        rigidbody.MovePosition(newPosition);
        
    }



    void OnTriggerEnter(Collider col)
    {
        Destroy(gameObject);
    }
  
}
