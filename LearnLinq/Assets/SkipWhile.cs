using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 如果指定的条件为 true，则跳过序列中的元素，然后返回剩余的元素。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.skipwhile?view=netstandard-2.1
/// </summary>

public class SkipWhile : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1, 2, 3, 4 };
		var query = numbers.OrderBy(n => n).SkipWhile(n => n < 3);
		//输出序列中元素大于3的值
		foreach (var number in query)
			Debug.Log(number);
		//输出结果3,4
	}

	// Update is called once per frame
	void Update()
	{

	}
}
