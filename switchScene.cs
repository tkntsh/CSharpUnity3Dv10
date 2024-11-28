using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class switchScene : MonoBehaviour
{
    public Button switchButton;
    // Start is called before the first frame update
    void Start()
    {
        switchButton.onClick.AddListener(() => mainMenuUI());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mainMenuUI()
    {
        SceneManager.LoadScene("sceneUI");
    }
}
