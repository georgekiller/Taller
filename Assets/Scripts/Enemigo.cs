using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float visionRadio;
    public float speed;
    [SerializeField]
    public float DañoE=1f;
    public double c;

    GameObject player;
    Vida playerVida;
    movimiento movimiento1;

    Vector3 initialPosition;
    Animator ene;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerVida = player.GetComponent<Vida>();

        initialPosition = transform.position;
        ene = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = initialPosition;

        float dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist < visionRadio) target = player.transform.position;
        if (initialPosition != Vector3.zero)
        {
            float fixedspeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position,
                target, fixedspeed);
            ene.SetBool("caminando", true);
        }
        else
        {
            ene.SetBool("caminando",false);
        }
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerVida.Daño(DañoE);
        }
        if (collision.CompareTag("bala"))
        {
            player.GetComponent<movimiento>().municion+=5;
            Destroy(gameObject);
            
        }
    }
}
