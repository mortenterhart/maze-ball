using UnityEngine;

namespace Common.Scripts.Game
{
    public class SetTargetFps : MonoBehaviour
    {
        [SerializeField] private int targetFps;
    
        private void Start()
        {
            Application.targetFrameRate = targetFps;
        }
    }
}
