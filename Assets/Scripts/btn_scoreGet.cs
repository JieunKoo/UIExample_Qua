using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// TODO : 점수를 관리합니다.

public class btn_scoreGet : MonoBehaviour 
{
	public Text txt; // 점수표시 txt
	public static int score = 0; //클래스 변수 타입의 score

	void Start () {
		txt = this.GetComponent<Text> (); //Text Component를 호출
	}

	public void scoreUP () {
		score += 100; // 누를때마다 100씩
		txt.text = score.ToString(); // 점수표시
		//Debug.Log (score);
	}
}
