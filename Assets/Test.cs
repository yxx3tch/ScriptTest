﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
	private int hp = 100;          // 体力
	private int power = 25; // 攻撃力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public  void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

}

public class Test : MonoBehaviour {
	// 第一引数と第二引数の値を足した値を返す関数
	int Add(int a, int b, int d){
		// 第一引数と第二引数の値を足して、変数cに代入する
		int c = a + b + d;
		// 変数cを呼び出し元の関数に返す
		return c;
	}

	// Use this for initialization
	void Start()
	{
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);

		Boss midboss = new Boss();
		midboss.Attack();
		midboss.Defence(30);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
