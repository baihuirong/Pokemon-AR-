using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonBack_Click : MonoBehaviour {

	public Button mButton;

	// Use this for initialization
	void Start () {
		//获取回退按钮事件
		Button btn = mButton.GetComponent<Button>();
		//给回退按钮2绑定监听器点击时执行TASKONCLICK方法
		btn.onClick.AddListener (TaskOnClick);
	}

	// Update is called once per frame
	void TaskOnClick() {
		//加载菜单场景2
		Application.LoadLevel(0);
	}
}
