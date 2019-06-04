using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 反转序列中元素的顺序
/// </summary>
public class Reverse : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1,2,3,4,5};
		foreach (var number in numbers.Reverse())
			Debug.Log(number);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
