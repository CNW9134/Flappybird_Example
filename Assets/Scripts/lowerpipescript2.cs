using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;

public class lowerpipescript2 : MonoBehaviour
{
    public Vector2 m_v2RandRange = new Vector2(-6f, -3f);

    // Start is called before the first frame update
    void Start()
    {
        float fStartX = transform.position.x;
        float fRandY = Random.Range(m_v2RandRange.x, m_v2RandRange.y);
        transform.position = new Vector3(fStartX, fRandY, 0);
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.left * Time.deltaTime);

        if (transform.position.x >= -5f)
            return;

        transform.position = new Vector3(5, Random.Range(-6f, -3f));
    }
}
