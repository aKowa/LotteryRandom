using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LotteryRandomInt))]
public class LotteryRandomIntInspector : Editor
{
	private bool accessed;

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();
		var randomInt = target as LotteryRandomInt;

		if (randomInt == null)
		{
			Debug.LogError("MemoGenerator not assigned");
			return;
		}

		if (GUILayout.Button("Memo Randomize"))
		{
			randomInt.SetNumber();
			accessed = true;
		}

		if (GUILayout.Button("Remove"))
		{
			randomInt.Remove();
			accessed = false;
		}
		
		if (GUILayout.Button("Clear"))
		{
			randomInt.Clear();
			accessed = false;
		}

		var label = "Picked: ";
		if (!accessed)
			label += "none";
		else
			label += randomInt.Number;

		if (randomInt.GetLastEntry())
			label += " (list is empty)";

		GUILayout.Label(label);
	}
}
