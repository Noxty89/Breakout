using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] public int limiteX = 25;
    [SerializeField] public float velocidadPaddle = 30f;

    Vector3 mousePos2D;
    Vector3 mousePos3D;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bola")
        {
            Vector3 direccion = collision.contacts[0].point - transform.position;
            direccion = direccion.normalized;
            collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos2D = Input.mousePosition;
        mousePos3D.z = -Camera.main.transform.position.z;
        mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //mueve el objeto a la derecha
            this.transform.Translate(Vector3.down * velocidadPaddle * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //mueve el obejto a la Izquierda
            this.transform.Translate(Vector3.up * velocidadPaddle * Time.deltaTime);

        }
        this.transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * velocidadPaddle * Time.deltaTime);

        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        if (pos.x < -limiteX)
        {
            pos.x = -limiteX;

        }else if(pos.x > limiteX)
        {
            pos.x = limiteX;

        }
        transform.position = pos;

    }
}
