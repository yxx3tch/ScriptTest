using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start()
	{
		// 配列を初期化する
		int[] points = {30, 20, 50, 10, 80, 15, 60, 100, 1000};
                
		// 配列の要素数のぶんだけ処理を繰り返す
		for (int i = 0; i < points.Length; i++) {
			// 配列の要素が50以上の場合
			if( points[i] >= 50 ){
				// 配列の要素を表示する
				Debug.Log (points [i]);
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
