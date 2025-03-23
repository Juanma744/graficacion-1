using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyController : MonoBehaviour
{
    public float health = 100;
    public Rigidbody2D rb2d;
    public float speed = 5;
    public float direccion = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = Vector2.left * speed * direccion;
        transform.localScale = new Vector2()
    }
    public void geetDamage(float amount)
    {
        health = (health > 0) ? health - amount : health;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("wall"))
            direccion *= 1;
    }
}
