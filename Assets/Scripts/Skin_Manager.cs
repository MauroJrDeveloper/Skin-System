using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin_Manager : MonoBehaviour
{

	public SpriteRenderer _Head_Renderer;
	public SpriteRenderer _Body_Renderer;

	public SpriteRenderer _Left_Up_Arm_Renderer;
	public SpriteRenderer _Right_Up_Arm_Renderer;

	public SpriteRenderer _Left_Bottom_Arm_Renderer;
	public SpriteRenderer _Right_Bottom_Arm_Renderer;

	public SpriteRenderer _Left_Leg_Renderer;
	public SpriteRenderer _Right_Leg_Renderer;

	public List<Sprite> _Head_Sprites;
	public List<Sprite> _Body_Sprites;

	public List<Sprite> _Left_Up_Arm_Sprites;
	public List<Sprite> _Right_Up_Arm_Sprites;

	public List<Sprite> _Left_Bottom_Arm_Sprites;
	public List<Sprite> _Right_Bottom_Arm_Sprites;

	public List<Sprite> _Left_Leg_Sprites;
	public List<Sprite> _Right_Leg_Sprites;

	public Color[] _Skin_Color;

    private void Start()
    {
		Skin_Options._Skin_Value = PlayerPrefs.GetInt("_Skin_Value");
		Set_Skin();
	}

    public void Set_Skin()
	{

		/*
		* In this case, I dont have art for use as skin, so I create a system that change the color.
		* If you have art, only need delete the next code block, that change color.
		*/

		#region Changing Character Parts

		/*
        _Head_Renderer.sprite = _Head_Sprites[_Skin_Value];
		_Body_Renderer.sprite = _Body_Sprites[_Skin_Value];

		_Left_Up_Arm_Renderer.sprite = _Left_Up_Arm_Sprites[_Skin_Value];
		_Right_Up_Arm_Renderer.sprite = _Right_Up_Arm_Sprites[_Skin_Value];

		_Left_Bottom_Arm_Renderer.sprite = _Left_Bottom_Arm_Sprites[_Skin_Value];
		_Right_Bottom_Arm_Renderer.sprite = _Right_Bottom_Arm_Sprites[_Skin_Value];

		_Left_Leg_Renderer.sprite = _Left_Leg_Sprites[_Skin_Value];
		_Right_Leg_Renderer.sprite = _Right_Leg_Sprites[_Skin_Value];
		*/

		#endregion

		#region Changing Color

		_Head_Renderer.color = _Skin_Color[Skin_Options._Skin_Value];
		_Body_Renderer.color = _Skin_Color[Skin_Options._Skin_Value];

		_Left_Up_Arm_Renderer.color = _Skin_Color[Skin_Options._Skin_Value];
		_Right_Up_Arm_Renderer.color = _Skin_Color[Skin_Options._Skin_Value];

		_Left_Bottom_Arm_Renderer.color = _Skin_Color[Skin_Options._Skin_Value];
		_Right_Bottom_Arm_Renderer.color = _Skin_Color[Skin_Options._Skin_Value];

		_Left_Leg_Renderer.color = _Skin_Color[Skin_Options._Skin_Value];
		_Right_Leg_Renderer.color = _Skin_Color[Skin_Options._Skin_Value];

		#endregion

		if (Skin_Options._Skin_Value != PlayerPrefs.GetInt("_Skin_Value"))
		{
			PlayerPrefs.SetInt("_Skin_Value", Skin_Options._Skin_Value);
		}

	}

}
