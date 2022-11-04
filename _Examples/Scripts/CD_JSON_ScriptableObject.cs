namespace CocodriloDog.CD_JSON.Examples {

	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	[CreateAssetMenu(menuName ="Cocodrilo Dog/CD JSON/Examples/CD JSON Scriptable Object")]
	public class CD_JSON_ScriptableObject : ScriptableObject {


		#region Private Fields

		[SerializeField]
		private CD_JSON_Example.Class1 m_Class1;

		[SerializeField]
		private CD_JSON_ScriptableObject m_ChildSO;

		[SerializeField]
		private string m_SomeOtherString;

		[SerializeField]
		private List<CD_JSON_PolymorphicBase> m_PolymorphicList;

		#endregion


	}

}
