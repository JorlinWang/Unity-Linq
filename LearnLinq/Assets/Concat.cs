using System.Linq;
using UnityEngine;

/// <summary>
/// 连接两个序列。
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.concat?view=netframework-4.6.1
/// </summary>
public class Concat : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		int[] a = { 1, 2, 3 };
		int[] b = { 4, 5, 6 };
		_ = a.Concat(b);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
