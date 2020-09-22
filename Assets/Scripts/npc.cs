using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    public float visionRadio;
    public float speed;

    public GameObject player;

    Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        
        
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("enemigo3");
        //

        Vector3 target = initialPosition;

        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < visionRadio) target = player.transform.position;
        if (initialPosition != Vector3.zero)
        {
            float fixedspeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position,
                target, fixedspeed);
            
        }
        //player = GameObject.FindGameObjectWithTag("enemigo2");

    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("enemigo1"))
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
