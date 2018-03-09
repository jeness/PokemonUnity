using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1_click : MonoBehaviour {
    
    public Button mButton;

    // Use this for initialization
    void Start () {
        Button btn = mButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick() {
        Application.LoadLevel(1);
    }
	
}
