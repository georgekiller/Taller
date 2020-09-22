using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour  
{
    [SerializeField]
    float salud_inici = 100f;
    float salud_actual;
    [SerializeField]
    Slider barra;
    // Start is called before the first frame update
    void Start()
    {
        salud_actual = salud_inici;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Daño(float DañoV)
    {
        salud_actual -= DañoV;
        barra.value = salud_actual;

        if (salud_actual <= 0)
            Destroy(gameObject);
    }
}
