using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn2 : MonoBehaviour
{
    public GameObject enemigo1;
    public float tiempo;
    public float contador;
    private float contador1;
    // Start is called before the first frame update
    void Start()
    {
        contador1 = contador;
    }

    // Update is called once per frame
    void Update()
    {
        contador -= Time.deltaTime;
        tiempo += Time.deltaTime;
        if(tiempo>=20 && tiempo <= 30)
        {
            if (contador <= 0)
            {
                GameObject newitem = Instantiate(enemigo1, transform.position, Quaternion.identity);
                contador = contador1;
            }
        }
    }
}
