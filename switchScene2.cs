using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class switchScene2 : MonoBehaviour
{
    public Button switchButton;
    // Start is called before the first frame update
    void Start()
    {
        switchButton.onClick.AddListener(() => arScene());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void arScene()
    {
        SceneManager.LoadScene("arScene");
    }
}
