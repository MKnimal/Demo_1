using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float Defensa = 1;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
            animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void TomarDaño(float dañoGolpe)
    {
        vida = vida - dañoGolpe;
            animator.SetTrigger("ded");
        if (vida <= 0){
            Muerte();
        }
    }

    private void Muerte(){
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Enemigo: Hubo una colision [" + collision.transform.tag + "]");
        if (collision.transform.tag == "Weapon")
        {
            TomarDaño(Defensa);
        }
    }
}
