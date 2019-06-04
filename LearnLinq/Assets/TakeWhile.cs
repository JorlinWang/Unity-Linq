using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 如果指定的条件为 true，则返回序列中的元素，然后跳过剩余的元素。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.takewhile?view=netstandard-2.1
/// </summary>

public class TakeWhile : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1,2,3,4,12,312,1};
		//取出小于3的元素
		foreach (var number in numbers.TakeWhile(n => n < 3))
			Debug.Log(number);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
