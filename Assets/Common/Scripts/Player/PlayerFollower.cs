using UnityEngine;

public class PlayerFollower : MonoBehaviour
{
    private GameObject _player;
    [SerializeField] private float _yOffset;

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        pos.y = _player.transform.position.y + _yOffset;
        transform.position = pos;
    }
}
