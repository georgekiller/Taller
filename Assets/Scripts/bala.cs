using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public float velocidad;
    public Vector3 target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    target = Camera.main.ScreenToWorldPoint(Input.mousePosition);                        
        //}
        target.z = 0f;
        transform.position = Vector3.MoveTowards(transform.position, target, velocidad * Time.deltaTime);
        Debug.DrawLine(transform.position, target, Color.green);
        if (Vector3.Distance(transform.position, target) <= 0.1f) 
        {
            Destroy(gameObject);
        }
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemigo1"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("enemigo2"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("enemigo3"))
        {
            Destroy(gameObject);
        }
    }
}
