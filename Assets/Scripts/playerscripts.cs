using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class playerscripts : MonoBehaviour
{
    private bool m_bSpaced;

    public float m_fMaxY = 5.0f;
    public float m_fMinY = -5.0f;
    public float m_fForceCoefficient = 300.0f;

    private const int m_nPipeLayer = 6;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(0, 1, 0);

        m_bSpaced = false;
    }


    private void FixedUpdate()
    {
        if (transform.position.y > m_fMaxY)
            transform.position = new Vector2(0, m_fMaxY);
        else if (transform.position.y < m_fMinY)
            transform.position = new Vector2(0, m_fMinY);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.up * m_fForceCoefficient);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer != m_nPipeLayer)
            return;

        bool bCond = true;
        if (!bCond)
            return;

        Time.timeScale = 0;
    }
}


    
           

       
        

    














