using UnityEngine;
using UnityEngine.UI;

public class ContinueButtonHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("levelSave") == 0)
            GetComponent<Button>().interactable = false;
    }
}

