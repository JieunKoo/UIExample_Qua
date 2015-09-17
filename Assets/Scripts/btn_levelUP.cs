using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// TODO : 레벨을 상승시킵니다.

public class btn_levelUP : MonoBehaviour
{
	public int level = 0; //0 부터 시작
	public Text txt; // 레벨 표시 txt
	public Image[] img; //레벨별 바뀌는 이미지. 3장

	public void start ()	{
		txt = this.GetComponent<Text>();//Text Component를 호출
	}

	public void UP () {
		level++; //누를때 마다 레벨증가

		switch (level)
		{
			//1,2는 그대로
			//이미지 3장을 동시에 깔아놓고 차례로 삭제
			case 3: 
					Destroy(img[0]); 
					break;
			case 8: 
					Destroy(img[1]);
			level = 8; // 여기가 만렙인데 레벨업을 멈출수가 없네 ;ㅅ; 
					break;
		}

		//Debug.Log (level);

		txt.text = level.ToString ();//레벨 표시
	}
}
