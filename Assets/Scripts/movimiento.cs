using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
   
{
    public float speed=4f;
    Animator anim;
    Rigidbody2D rb2d;
    Vector2 mov;
    public GameObject bala;

    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mov = new Vector2(Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"));
        
        if (mov != Vector2.zero)
        {
            anim.SetFloat("movX", mov.x);
            anim.SetFloat("movY", mov.y);
            anim.SetBool("caminando", true);
        }
        else
        {
            anim.SetBool("caminando", false);
        }

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bala1 = Instantiate(bala, transform.position, Quaternion.identity);
            bala1.GetComponent<bala>().target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //target.z = 0f;
        }
    }
    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + mov * speed * Time.deltaTime);
    }
}
