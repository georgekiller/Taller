using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crear : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;


    public float tiempo;
    public float contador;
    private float contador1;
    public int ducount;

    // Start is called before the first frame update
    void Start()
    {
        //GameObject newitem = Instantiate(item,transform.position,Quaternion.identity);
        contador1 = contador;
    }

    // Update is called once per frame
    void Update()
    {
        // if (ducount < 5)
        //{
        contador -= Time.deltaTime;
        tiempo += Time.deltaTime;
        if (tiempo <= 15)
        {
            if (contador <= 0)
            {
                if (tiempo >= 1 && tiempo <= 5)
                {

                    GameObject newitem = Instantiate(item1, transform.position, Quaternion.identity);
                    contador = contador1;
                    //Destroy(newitem,2);
                }
                if (tiempo >= 6 && tiempo <= 10)
                {
                    GameObject newitem = Instantiate(item2, transform.position, Quaternion.identity);
                    contador = contador1;
                    //Destroy(newitem, 2);
                }
                if (tiempo >= 11 && tiempo <= 15)
                {

                    GameObject newitem = Instantiate(item3, transform.position, Quaternion.identity);
                    contador = contador1;
                    //Destroy(newitem, 2);
                }

            }


        }
        else
        {
            //GameObject[] enemigo1 = GameObject.FindGameObjectsWithTag("enemigo1");
            //Debug.Log(enemigo1.Length);

            //GameObject[] enemigo2 = GameObject.FindGameObjectsWithTag("enemigo2");
            //Debug.Log(enemigo1.Length);

            //GameObject[] enemigo3 = GameObject.FindGameObjectsWithTag("enemigo3");
            //Debug.Log(enemigo1.Length);

            //int e1 = Random.Range(0, enemigo1.Length);

            //Destroy(enemigo1[e1],2);
        }  
    }
}

        //}

