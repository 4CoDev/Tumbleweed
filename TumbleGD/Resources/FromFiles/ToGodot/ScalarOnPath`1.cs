using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Resources.FromFiles.ToGodot;

public sealed class ScalarOnPath<T> : ScalarEnvelope<T> where T : class
{
	public ScalarOnPath(string path) : this
	(
		new ScalarOfValue<string>(path)
	)
	{
	}
	
	public ScalarOnPath(IScalar<string> path) : base
	(
		new ScalarOfDelegate<T>(
			() => ResourceLoader.Load<T>(path.Value))
	)
	{
	}
}