using UnityEngine;
using System.Collections;

public class Boss {        

	private int mp = 53; //マジックポイント

	//Magic関数
	public void Magic(){
		int decmp = this.mp - 5;

		if (decmp < 0) {
			//mpが0未満の場合
			Debug.Log ("MPが足りないため魔法が使えない");
		} else {
			//mpが0以上の場合
			Debug.Log ("魔法攻撃をした 残りMPは" + decmp);
		}
		//残りmpを減らす
		this.mp = decmp;
		}
}


public class Test2 : MonoBehaviour {

	void Start () {
		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();

		// 11回まで処理を繰り返す
		for (int i = 0; i < 11; i++) {
			// Magic関数を呼び出す
			lastboss.Magic();
		}
	}
	// Update is called once per frame
	void Update () {

	}
}