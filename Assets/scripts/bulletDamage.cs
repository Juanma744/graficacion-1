using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class bulletmovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = Vector2.left * Speed * direccion;
        transform.localScale = new Vector2(direccion)
    }
}
