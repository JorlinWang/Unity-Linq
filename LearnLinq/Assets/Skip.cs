using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 跳过序列中指定数量的元素，然后返回剩余的元素。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.skip?view=netframework-4.6.1
/// </summary>
public class Skip : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1,2,3,4};
		//从头开始，跳过2个元素
		foreach (var number in numbers.Skip(2))
			Debug.Log(number);
		//输出结果3,4
	}

	// Update is called once per frame
	void Update()
	{

	}
}
