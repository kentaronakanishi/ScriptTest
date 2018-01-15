using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	private int hp =100;
	private int power = 25;
	private int mp = 53;

	//攻撃用関数
	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}

	//防御用関数
	public void Deffence(int damage){
		Debug.Log (damage + "のダメージを受けた");
		//残りHPを減らす
		this.hp -= damage;
	}

	//魔法の関数
	public void Magic(){
		if (mp < 5) {
			Debug.Log ("mpが足りないため魔法が使えない");
		} else {
			this.mp = this.mp - 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);
		}
}
}
			

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
				//Bossクラスの変数を宣言してインスタンスを代入
		Boss Lastboss = new Boss ();
		//攻撃用の関数を呼び出す
		Lastboss.Attack();
		//防御用の関数を呼び出す
		Lastboss.Deffence(3);
		//for関数で魔法用の関数を１０回呼び出す
		for (int i = 1; i <= 10; i++) {
			Lastboss.Magic ();
		}
		//１１回目の魔法が使えないことを確認する
		Lastboss.Magic ();
	}

	
	// Update is called once per frame
	void Update () {
		
	}

}
