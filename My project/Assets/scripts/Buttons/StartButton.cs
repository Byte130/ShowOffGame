using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{

    public string SceneName;

    void Start()
    {
        var btn = GetComponent<Button>();
        if (btn != null)
            btn.onClick.AddListener(OnButtonPressed);
    }

    public void OnButtonPressed()
    {
        if (!string.IsNullOrEmpty(SceneName))
            SceneManager.LoadScene(1);
    }
}