using UnityEngine;

public class LevelSaveRemover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("levelSave", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
