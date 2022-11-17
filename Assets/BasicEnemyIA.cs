using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyIA : MonoBehaviour
{
    private Rigidbody2D Enemigo;
    private GameObject Player;
    private float speed = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        Enemigo = GetComponent<Rigidbody2D>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Enemigo.AddForce((Player.transform.position - transform.position).normalized * speed);
    }
}
