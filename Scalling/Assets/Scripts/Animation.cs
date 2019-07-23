using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof (Rigidbody2D ))]
public class Animation : MonoBehaviour
{
    public float jumpForce = 100f;
    private Rigidbody2D rgb2d;
    public UiManager ui;
    // Start is called before the first frame update
    void Start()
    {
        rgb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input .GetMouseButtonDown(0))
        {
            rgb2d.AddForce(new Vector2(0, jumpForce));
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            ui.gameOverActivated();
        }
    }
}
