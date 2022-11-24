using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    float horizontal;
    Rigidbody2D catcher;

    // Start is called before the first frame update
    void Start()
    {
        catcher = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        catcher.velocity = new Vector2(horizontal * moveSpeed, 0);
    }
}
