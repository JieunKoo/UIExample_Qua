using UnityEngine;
using System.Collections;

// TODO : modal_panel에 적용
// OnEnable() 자체가 '활성화'되면 호출

public class BringToFront : MonoBehaviour 
{
	void OnEnable () {
		transform.SetAsLastSibling (); //hierarchy 가장 마지막으로 순서 변경
	}
}
