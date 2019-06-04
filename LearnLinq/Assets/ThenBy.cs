using UnityEngine;
using System.Collections;
using System.Linq;
/// <summary>
/// 按升序对序列中的元素执行后续排序。
/// </summary>
public class ThenBy : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		string[] fruits = { "b", "as", "a", "bsa", "ca", "asdfs"};
		foreach (var fruit in fruits.OrderBy(fruit => fruit.Length).ThenBy(fruit => fruit))
			Debug.Log(fruit);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
