using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;

public class lowerpipescript : MonoBehaviour
{

    public GameObject PipePrefab;
    
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(5, Random.Range(-6f, -3f));
        
    }


   
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * Time.deltaTime);

        if (transform.position.x<-5f) 
        {
           transform.position = new(5, Random.Range(-6f, -3f));
        } 
            
    }
}
