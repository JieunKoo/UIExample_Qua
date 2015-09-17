using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

//TODO : 시작 버튼
// 클릭하면 Scene_main으로 이동합니다. 

public class btn_startclick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	bool btn_down = false;
	
	//YES
	public void OnPointerDown (PointerEventData ped) {
		btn_down = true;
	}

	//NO
	public void OnPointerUp (PointerEventData ped) {
		btn_down = false;
	}

	void Update () {
		if (btn_down) 
		{
			Application.LoadLevel("Scene_main"); // 이동
			btn_down = false;
		}
	}
	 
}
