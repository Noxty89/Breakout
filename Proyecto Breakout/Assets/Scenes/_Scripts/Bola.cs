using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bola : MonoBehaviour
{
    public bool isGameStarted = false;
    [SerializeField]public float velocidadBola = 23.0f;
    Vector3 UltimaPosicion = Vector3.zero;
    Vector3 Direccion = Vector3.zero;
    new Rigidbody rigidbody;
    private ControlBordes control;
    public UnityEvent BolaDestruida;

    private void Awake()
    {
        control = GetComponent<ControlBordes>();

    }
    // Start is called before the first frame update
    void Start()
    {
        Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicial.y += 3;
        this.transform.position = posicionInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
        rigidbody = this.gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if(control.SalioAbajo)
        {
            BolaDestruida.Invoke();
            Destroy(this.gameObject);

        }
        if (control.SalioArriba)
        {
            Direccion = transform.position - UltimaPosicion;
            Debug.Log("la Bola Toco La Parte Superior");
            Direccion.y *= -1;
            Direccion = Direccion.normalized;
            rigidbody.velocity = velocidadBola * Direccion;
            control.SalioArriba = false;
        }
        if (control.SalioDerecha)
        {
            Direccion = transform.position - UltimaPosicion;
            Debug.Log("la Bola Toco La Parte Derecha");
            Direccion.y *= -1;
            Direccion = Direccion.normalized;
            rigidbody.velocity = velocidadBola * Direccion;
            control.SalioDerecha = false;
        }
        if (control.SalioIzquierda)
        {
            Direccion = transform.position - UltimaPosicion;
            Debug.Log("la Bola Toco La Parte Izquierda");
            Direccion.y *= -1;
            Direccion = Direccion.normalized;
            rigidbody.velocity = velocidadBola * Direccion;
            control.SalioIzquierda = false;
        }

        if (Input.GetKey(KeyCode.Space) /*|| Input.GetButton("submit")*/) 
        {
            if (!isGameStarted)
            {
                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = velocidadBola * Vector3.up;


            }
        }

    }
    private void FixedUpdate()
    {
        UltimaPosicion = transform.position;

    }
    private void LateUpdate()
    {
        if (Direccion != Vector3.zero) Direccion = Vector3.zero;

    }
}
