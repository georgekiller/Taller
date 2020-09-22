using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemispawn : MonoBehaviour
{
    public GameObject item1;

    public float contador;
    [SerializeField]
    private float contador1;
    public int ducount;
    // Start is called before the first frame update
    void Start()
    {
        contador1 = contador;

    }

    // Update is called once per frame
    void Update()
    {
        contador -= Time.deltaTime;
        if (contador <= 0)
        {
            GameObject newitem = Instantiate(item1, transform.position, Quaternion.identity);
            contador = contador1;
        }
    }
}
