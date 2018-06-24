using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Button2_Click : MonoBehaviour {

	public Button mButton;

	// Use this for initialization
	void Start () {
		//获取按钮事件
		Button btn = mButton.GetComponent<Button>();
		//给按钮2绑定监听器点击时执行TASKONCLICK方法
		btn.onClick.AddListener (TaskOnClick);
	}

	// Update is called once per frame
	void TaskOnClick() {
		//加载场景2
		Application.LoadLevel(2);
	}
}
