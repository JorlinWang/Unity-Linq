using UnityEngine;
using System.Linq;
using System;
/// <summary>
/// 取最大值
/// https://docs.microsoft.com/zh-cn/dotnet/api/system.linq.queryable.max?view=netframework-4.6.1
/// </summary>
public class Max : MonoBehaviour
{
	class Pet {
		public string name;
		public uint age;
	}
	// Use this for initialization
	void Start()
	{
		int[] numbers = { 1, 2, 3, 4 };
		var max = numbers.Max();
		Debug.Log("max: " + max);

		var pets = new Pet[] {
			new Pet { name = "jorlin", age = 12},
			new Pet { name = "jorlin", age = 8},
			new Pet { name = "jorlin", age = 6},
		};
		var umax = pets.Max(pet => pet.age);
		Debug.Log("max: " + umax);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
