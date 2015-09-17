using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

//TODO : 모달 창을 관리합니다.
//Unity 자습서의 UI TOOLS:MAKING A GENERIC MODAL WINDOW 를 참고함. 

public class ModalPanel : MonoBehaviour 
{
	public Text result; //최종점수 표시용 txt
	public Button restart; //다시하기 버튼
	public Button gomain; //처음으로 버튼
	public GameObject modalPanelObject; //모달 창 자체(modal_panel)

	private static ModalPanel modalpanel; 

	//ModalPanel의 유무확인(?)
	public static ModalPanel Instace () {
		if (!modalpanel) 
		{
			modalpanel = FindObjectOfType(typeof (ModalPanel)) as ModalPanel;
			if(!modalpanel)
			{
				Debug.Log("ModalPanel need");
			}
		}
		return modalpanel;
	}

	//선택, Hpbar.cs의 CallModal()에서 사용. 
	public void Choice (UnityAction reEvent, UnityAction maEvent) {

		modalPanelObject.SetActive (true); // 모달창 활성화
		restart.onClick.RemoveAllListeners (); // 모든 리스너 제거 (초기화)
		restart.onClick.AddListener (reEvent); //reEvent 액션 추가
		restart.onClick.AddListener (ClosePanel); // 

		gomain.onClick.RemoveAllListeners (); 
		gomain.onClick.AddListener (maEvent);
		gomain.onClick.AddListener (ClosePanel);

		restart.gameObject.SetActive(true);
		gomain.gameObject.SetActive(true);

		//btn_scoreGet에 있는 score를 불러옴
		this.result.text = btn_scoreGet.score.ToString();

		//Debug.Log (result);
	}

	// 모달창 비활성화
	void ClosePanel () {
			modalPanelObject.SetActive (false);
	}

}
