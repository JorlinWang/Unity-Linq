using System.Linq;
using UnityEngine;
/// <summary>
/// 返回序列中的元素数量。
/// Count<TSource>(IQueryable<TSource>) 
/// 返回指定序列中满足条件的元素数量。
/// Count<TSource>(IQueryable<TSource>, Expression<Func<TSource,Boolean>>)
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.count?view=netframework-4.6.1
/// </summary>
public class Count : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1, 2, 3 };
		Debug.Log(numbers.Count());
		Debug.Log(numbers.Count(number => number > 1));
	}

	// Update is called once per frame
	void Update()
	{

	}
}
