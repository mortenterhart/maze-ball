using UnityEngine;

namespace Common.Scripts.Collectable
{
    public class CollectableHandler : MonoBehaviour
    {
        [SerializeField] private ParticleSystem particles;
        private Animator _animator;
        private CapsuleCollider _cc;
        public bool destroy;

        private void Start()
        {
            _animator = GetComponent<Animator>();
            _cc = GetComponent<CapsuleCollider>();
        }

        private void Update()
        {
            if (!destroy) return;
            Destroy(gameObject);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Player")) return;

            var instance = Instantiate(particles, transform.position, Quaternion.identity);
            instance.transform.eulerAngles = Vector3.left * 90f;
            Events.OnCollectableCollected();
            Events.OnPlayCollectableSfx();
            transform.SetParent(transform.parent.transform.parent);
            _animator.SetBool("destroy", true);
            _cc.enabled = false;
        }
    }
}