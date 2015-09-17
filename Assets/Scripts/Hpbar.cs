using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

// TODO : HP를 표시하는 스크롤바.
// 최대 HP는 100 으로, outch!(btn_damage) 버튼을 누를 때 마다 value(10)씩 깎입니다.
// 0이되면 자동으로 결과창(모달 박스)이 표시됩니다.
// Unity 자습서의 UI TOOLS:MAKING A GENERIC MODAL WINDOW 를 참고함. 

public class Hpbar : MonoBehaviour 
{
	private ModalPanel modalpanel; 
	UnityAction reEventAction;
	UnityAction maEventAction;

	public Scrollbar hp; //스크롤바
	public float max_hp = 100.0f; //최대 HP
	public float value; //데미지 값

	//준비 
	void Awake () {
		modalpanel = ModalPanel.Instace ();
		
		reEventAction = new UnityAction (CallRestartFunc);
		maEventAction = new UnityAction (CallGomainFunc);
	}

	//스크롤바 상태변경
	public void Damage (float value) {
		max_hp -= value; 
		hp.size = max_hp / 100.0f;
		//Debug.Log ("outch!");

		//HP가 0이 되면 
		if (max_hp == 0) 
		{
			CallModal(); //모달창 호출 
		}
	}

	//모달 불러오기
	public void CallModal () {
		modalpanel.Choice (CallRestartFunc,CallGomainFunc);
	}

	//reEvent
	public void CallRestartFunc()
	{
		//다시시작
		Application.LoadLevel ("Scene_main");
	}

	//maEvent
	public void CallGomainFunc()
	{
		//처음으로
		Application.LoadLevel ("Scene_start");
	}

}
