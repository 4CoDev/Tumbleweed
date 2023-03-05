using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Resources.FromFiles.ToGodot;

public sealed class ScalarOnPath<T> : ScalarEnvelope<T> where T : class
{
	public ScalarOnPath(String path) : this
	(
		new ScalarOfValue<String>(path)
	)
	{
	}
	
	public ScalarOnPath(IScalar<String> path) : base
	(
		new ValueOfDelegate<T>(
			() => ResourceLoader.Load<T>(path.Value))
	)
	{
	}
}