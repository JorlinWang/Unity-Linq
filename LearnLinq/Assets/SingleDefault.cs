using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 如果不找到任何此类元素，则返回一个特定元素序列，或默认值。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.singleordefault?view=netframework-4.6.1
/// </summary>

public class SingleDefault : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1, 2, 3 };
		int[] numbers2 = { 1 };
		Debug.Log(numbers.SingleOrDefault(number => number == 4));
		//输出结果为0，找不到这个值，返回默认值
	}

	// Update is called once per frame
	void Update()
	{

	}
}
