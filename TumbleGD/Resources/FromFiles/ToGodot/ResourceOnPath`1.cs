using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Resources.FromFiles.ToGodot;

public sealed class ResourceOnPath<T> : ScalarEnvelope<T> where T : class
{
	public ResourceOnPath(String path) : this
	(
		new ScalarOfValue<String>(path)
	)
	{
	}
	
	public ResourceOnPath(IScalar<String> path) : base
	(
		new ValueOfDelegate<T>(
			() => ResourceLoader.Load<T>(path.Value))
	)
	{
	}
}