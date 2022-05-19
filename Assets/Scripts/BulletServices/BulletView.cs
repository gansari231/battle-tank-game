using System;
using UnityEngine;

namespace BulletServices
{
    [RequireComponent(typeof(Rigidbody))]
    public class BulletView : MonoBehaviour
    {
        private BulletController bulletController;

        public ParticleSystem explosionParticles;
        public AudioSource explosionSound;

        public LayerMask layerMask;
        internal bool activeInHierarchy;

        public void SetBulletController(BulletController controller)
        {
            bulletController = controller;
        }

        private void Start()
        {
            Destroy(gameObject, bulletController.bulletModel.maxLifeTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            bulletController.OnCollisionEnter(other);
        }

        public void DestroyBullet()
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }

        public void DestroyParticleSystem(ParticleSystem particles)
        {
            Destroy(particles.gameObject, particles.main.duration);
        }
    }
}
