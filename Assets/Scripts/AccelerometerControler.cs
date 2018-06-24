using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerControler: MonoBehaviour {

	float speed=200;//位移速度为200

	static bool isTouched = false;//表示屏幕是否被点击的static变量
	// Use this for initialization
	void Start () {
		isTouched = false;
	}
	
	// Update is called once per frame
	void Update () {
		//如果屏幕被点击至少一次
		if (Input.touchCount >= 1) {
			isTouched = true;
		}
		if(isTouched)
		{//表示三维的随重力加速度的位移向量
		   Vector3 mMovement = new Vector3 (
			 Input.acceleration.x *speed*Time.deltaTime,
			 Input.acceleration.y *speed*Time.deltaTime);
			//根据向量来移动游戏对象
		   transform.Translate (mMovement);//控制当前脚本绑定到游戏对象位移，transla改变游戏方向相应位移
		}

	}
}
