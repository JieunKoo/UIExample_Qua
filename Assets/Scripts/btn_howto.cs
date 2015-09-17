using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// TODO : 게임방법 창을 표시합니다.

public class btn_howto : MonoBehaviour
{
	public GameObject img; //GameObject 타입 게임설명 이미지, 비활성화(false) 되어있다.
	public Button btn; // btn_howto 버튼

	//btn_howto에서 호출한다
	public void show () {
		//Debug.Log("clicked");
		img.gameObject.SetActive (true); //오브젝트를 활성화시킴. 
	}
}
