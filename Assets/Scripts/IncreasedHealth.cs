using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasedHealth : MonoBehaviour
{
    public AudioClip collectedClip;
    public ParticleSystem PickupParticles;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(3);
                ParticleSystem hitFX = Instantiate(PickupParticles, transform.position, Quaternion.identity);
                Destroy(gameObject);

                controller.PlaySound(collectedClip);
            }
        }

    }
}