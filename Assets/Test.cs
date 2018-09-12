using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 要素数5の配列を初期化する
		int[] points = {10,200,3000,40000,500000};

		// 配列の要素をすべて表示する
			for (int i = 0; i < points.Length; i++) {
			Debug.Log (points [i]);
		}
		//逆順に表示する
		for (int i = 4; i>=0; i--){
			
			Debug.Log(points[i]);
		}	
	}


	
	// Update is called once per frame
    void Update () {
		
	}
}
