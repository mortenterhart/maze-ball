using UnityEngine;

public class CollectableHandler : MonoBehaviour
{
    [SerializeField] private ParticleSystem particles;
    private Animator _animator;
    public bool destroy;

    private void Start()
    {
        _animator = GetComponent<Animator>();
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
        _animator.SetBool("destroy", true);
    }
}
