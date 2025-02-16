using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class playerscripts : MonoBehaviour
{
    // Start is called before the first frame update



    void Start()

    {
        
        this.transform.position = new Vector2(0, 1);
        Time.timeScale = 1;
        return;
    }

    // Update is called once per frame
    void Update()
    {



        if (transform.position.y > 5f)
            transform.position = new Vector2(0, 5f);

        else if (transform.position.y < -5f)
            transform.position = new Vector2(0, -5f);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * 300);
        }
    }




        private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;

    }

}


    
           

       
        

    














