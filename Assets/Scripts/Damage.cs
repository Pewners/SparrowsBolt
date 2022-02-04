using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    float damage = 5f;

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<CharacterController>().TakeDamage(damage);
    }
}
