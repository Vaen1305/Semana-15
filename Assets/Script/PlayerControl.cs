using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speedX;
    public GameObject bulletPrefab;
    public GameObject sonidodisparo;
    private Rigidbody2D _compRigidbody;
    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical);
        _compRigidbody.velocity = movimiento * speedX;
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
            Instantiate(sonidodisparo);
        }
    }
}
