using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Resources.FromFiles.ToGodot;

public sealed class ResourceOnPath<T> : ScalarEnvelope<T> where T : class
{
	public ResourceOnPath(String path) : this
	(
		new ScalarValue<String>(path)
	)
	{
	}
	
	public ResourceOnPath(IScalar<String> path) : base
	(
		new ResultOfFunction<T>(
			() => ResourceLoader.Load<T>(path.Value))
	)
	{
	}
}