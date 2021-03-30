using UnityEngine;

public class ClickableObstacle : MonoBehaviour
{
    [SerializeField] private int numberOfClicks = 5;
    //[SerializeField] private float regenSpeed = 10f;
    private Vector3 _initialScale;
    private int _currentNumberOfClicks;
    
    // Start is called before the first frame update
    private void Start()
    {
        _initialScale = transform.localScale;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        _currentNumberOfClicks++;
        transform.localScale -= _initialScale * 0.2f;

        if (_currentNumberOfClicks < numberOfClicks) return;
        Destroy(gameObject);
    }
}