using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;

        if (collidedWith.tag != "Wall")
        {
            Destroy(collidedWith);
            Destroy(gameObject);
        }
    }
}
