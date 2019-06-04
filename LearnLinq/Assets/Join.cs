using System.Linq;
using UnityEngine;
/// <summary>
/// 基于匹配键对两个序列的元素进行关联。
/// </summary>

public class Join : MonoBehaviour
{
	class Person
	{
		public string name;
	}
	class Pet
	{
		public string name;
		public Person owner;
	}
	private void Start()
	{
		Person[] persons = {
			new Person{ name = "a"},
			new Person{ name = "b"}
		};
		Pet[] pets = {
			new Pet{ name = "d1", owner = persons[0]},
			new Pet{ name = "d2", owner = persons[1]},
			new Pet{ name = "d3", owner = persons[1]},
		};
		var query = persons.Join(
			pets,
			person => person,
			pet => pet.owner,
			(person, pet) => new
			{
				Person = person.name,
				Pet = pet.name
			}
			);

		foreach (var obj in query)
			Debug.LogFormat("{0}-{1}", obj.Person, obj.Pet);

		// Update is called once per frame
		void Update()
		{

		}
	}
}
