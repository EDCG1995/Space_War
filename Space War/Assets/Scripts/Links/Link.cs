using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void GitHubRepositoryLink()
	{
#if !UNITY_EDITOR
		openWindow("https://github.com/EDCG1995/Space_War");
#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}