using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEntitie : MonoBehaviour
{
    [SerializeField] private float dañoGolpe;

    private void OnCollisionEnter(Collision collision) 
    {
        Debug.Log("Arma: Hizo colision");
        if (collision.transform.tag == "Enemy"){
            Debug.Log("Arma: Toco un enemigo");
            collision.transform.GetComponent<Enemigo>().TomarDaño(dañoGolpe);
        }
    }
}
