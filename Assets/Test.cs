using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 配列を初期化する
		int[] points = {1, 2, 3, 4, 5};

		// 配列の要素数のぶんだけ処理を繰り返す
		for (int i = 0; i < points.Length; i++) {
			// 配列の要素を順番に表示する
			Debug.Log (points [i]);
		}
			// 配列の要素数のぶんだけ処理を繰り返す
		for (int i = points.Length - 1; 0 <= i ; i--){
			// 配列の要素を逆順番に表示する
			Debug.Log (points [i]);	
		}
	}

	// Update is called once per frame
	void Update () {

	}
}