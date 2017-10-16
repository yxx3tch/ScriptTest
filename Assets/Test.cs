using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {        
	private int hp = 100;       // 体力
	private int power = 25; 	// 攻撃力
	private int mp = 53; 		// 魔力

	// 攻撃用の関数
	public void Attack() { 
		Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public void Defence(int damage) { 
		Debug.Log( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	//　魔法用の関数
	public void Magic() {
		if (mp >= 5) {
			// mpを5消費する
			this.mp -= 5;
			Debug.Log( "魔法攻撃をした。残りMPは" + mp + "。" );
		} else {
			Debug.Log( "MPが足りないため魔法が使えない。" );
		}
	}
}

public class Test : MonoBehaviour {

	void display(int[] input){
		for (int i = 0; i < input.Length; i++){
			Debug.Log(input[i]);
		}
	}

	void display_invert(int[] input){
		for (int i = input.Length - 1; i >= 0; i--){
			Debug.Log(input[i]);
		}
	}

	// Use this for initialization
	void Start()
	{
		int[] array = {1, 2, 3, 4, 5};
		display(array);
		display_invert(array);

		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss();
		Boss midboss = new Boss();

		// 攻撃用の関数を呼び出す
		lastboss.Attack();
		midboss.Attack();
		// 防御用の関数を呼び出す
		lastboss.Defence(3);
		midboss.Defence(30);

		// 魔法用の関数を呼び出す
		for (int i = 0; i < 11; i++){
			lastboss.Magic();
	}
}

	// Update is called once per frame
	void Update () {
		
	}
}
