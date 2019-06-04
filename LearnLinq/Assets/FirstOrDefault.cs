using System.Linq;
using UnityEngine;
/// <summary>
/// 返回序列中的第一个元素；如果未找到该元素，则返回默认值。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.firstordefault?view=netframework-4.6.1
/// </summary>
public class FirstOrDefault : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1, 1, 2, 3, 4, 5 };
		Debug.Log(numbers.FirstOrDefault());
		Debug.Log(numbers.FirstOrDefault(number => number > 3));
	}

	// Update is called once per frame
	void Update()
	{

	}
}
