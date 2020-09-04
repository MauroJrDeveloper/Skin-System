using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin_Options : MonoBehaviour
{

	public static int _Skin_Value;

	public Skin_Manager _Skin_Manager_Script;

	GameObject _Button;

	void Start()
	{

		_Button = this.gameObject;
		_Skin_Manager_Script = GameObject.Find("Scene_Controller").GetComponent<Skin_Manager>();

	}

	public void Change_Skin()
	{

		switch (_Button.name)
		{

			case "Skin_0":
				_Skin_Value = 0;
				break;

			case "Skin_1":
				_Skin_Value = 1;
				break;

			case "Skin_2":
				_Skin_Value = 2;
				break;

			case "Skin_3":
				_Skin_Value = 3;
				break;

			case "Skin_4":
				_Skin_Value = 4;
				break;

		}

		_Skin_Manager_Script.Set_Skin();

	}



}
