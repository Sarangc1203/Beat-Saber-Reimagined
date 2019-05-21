using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardMotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= Time.deltaTime * transform.forward * 15;
    }

    public void OnCollisionEnter(Collision other) 
    {
        Debug.Log("Collision");
        if(other.gameObject.CompareTag("BackWall"))
        {
            Destroy(this.gameObject);
        }
    }
}
