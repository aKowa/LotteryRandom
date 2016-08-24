using UnityEngine;
using UnityEditor;

[CustomEditor(typeof( LotteryRandomAudioClip ) )]
public class LotteryRandomAudioClipInspector : Editor
{
	private bool accessed;

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();
		var randomInt = target as LotteryRandomAudioClip;

		if (randomInt == null)
		{
			Debug.LogError("MemoGenerator not assigned");
			return;
		}

		if (GUILayout.Button("Memo Randomize"))
		{
			randomInt.SetClip();
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
		else if (randomInt.Clip != null)
			label += randomInt.Clip.name;

		if (randomInt.IsLastEntry())
			label += " (list is empty)";

		GUILayout.Label(label);
	}
}
