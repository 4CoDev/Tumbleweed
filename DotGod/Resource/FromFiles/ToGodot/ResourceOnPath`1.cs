using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Resource.FromFiles.ToGodot;

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