using BepInEx;
using Photon.Pun;
using System.IO;

namespace GorillaMod
{
	[BepInPlugin("com.nova.gorillamod", "RPC Getter", "1.0.0")]
	public class Plugin : BaseUnityPlugin
	{
		public void Awake()
		{
			File.WriteAllLines(Path.Combine(Paths.PluginPath, "RPCS.txt"), PhotonNetwork.PhotonServerSettings.RpcList.ToArray());
		}
	}
}
