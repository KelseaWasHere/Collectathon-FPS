using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float life = 3;


    void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Destroyable"))
        {
            Destroy(collision.gameObject);
            life--;
            if (life <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            return;
        }
        if (gameObject.CompareTag("Solid"))
        {
            Destroy(collision.gameObject);
            return;
        }
        Destroy(collision.gameObject);
    }
}
