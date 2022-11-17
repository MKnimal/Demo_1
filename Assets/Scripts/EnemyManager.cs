using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private GameObject[] enemigos;
    [SerializeField] private float inicio = 2f;
    [SerializeField] private float interval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generate", inicio, interval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Generate(){
            Vector3 posicion = new Vector3(Random.Range(0, 10), Random.Range(0, 5), 0);    
            //Necesita 2 parametros, desde que numero y hasta que numero X, Y, Z
            int index = Random.Range(0, enemigos.Length);
            //Necesita que le mandes un parametro con que va a instanciar, la posicion y la direccion
            Instantiate(enemigos[index], posicion, enemigos[index].transform.rotation);
    }
}
