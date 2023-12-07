using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;

    public float delayToDestroy = 15f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, delayToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }
}
