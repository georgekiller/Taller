using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;

public class enemigodisp : MonoBehaviour
{
    public float visionRadius=4.52f;
    public float attackRadius=3.78f;
    public float speed;

    public GameObject disparo;
    public float attackspeed=2f;
    bool attacking;

    GameObject player;
    Vector3 initialPosition, target;
    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;

        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //target = initialPosition;

        RaycastHit2D hit = Physics2D.Raycast(transform.position,
            player.transform.position - transform.position, visionRadius, 1 << LayerMask.NameToLayer("player"));
        Vector3 forward = transform.TransformDirection(player.transform.position - transform.position);
        Debug.DrawRay(transform.position, forward, Color.red);

        if (hit.collider != null)
        {
            //Debug.Log("nanan");
            Debug.Log(hit.collider.tag);
            if (hit.collider.CompareTag("Player"))
            {
                target = player.transform.position;
                float distance = Vector3.Distance(target, transform.position);
                Vector3 dir = (target - transform.position).normalized;
                Debug.Log(distance);
                if (/*target != initialPosition*/ distance < attackRadius)
                {
                   // Debug.Log("inr" + " " + visionRadius + " " + attackRadius + " " + distance);
                    if (!attacking) StartCoroutine(Attack(attackspeed));
                }
                else
                {
                    rb2d.MovePosition(transform.position + dir * speed * Time.deltaTime);
                    //Debug.Log("lool");
                }
            }
        }
        else
        {
           
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRadius);
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }
    IEnumerator Attack(float seconds)
    {
        Debug.Log("entrando");
        attacking = true;
        if (target != initialPosition && disparo != null)
        {
            Instantiate(disparo, transform.position, transform.rotation);
            yield return new WaitForSeconds(seconds);
        }
        attacking = false;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bala"))
        {
            Destroy(gameObject);

        }
    }
}
