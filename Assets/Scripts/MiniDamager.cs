using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniDamager : MonoBehaviour
{
    [SerializeField] private float damage = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<HP>().TomarDaño(damage);
        }
    }
}
