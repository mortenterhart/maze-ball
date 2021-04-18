using UnityEngine;

public class SetTargetFps : MonoBehaviour
{
    [SerializeField] private int targetFps;

    private void Start()
    {
        Application.targetFrameRate = targetFps;
    }
}

