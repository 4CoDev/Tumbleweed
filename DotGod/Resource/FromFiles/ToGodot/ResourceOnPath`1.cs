using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Function;

namespace DotGod.Resource.FromFiles.ToGodot;

public sealed class ResourceOnPath<T> : Envelope<T> where T : class
{
	public ResourceOnPath(String path) : this
	(
		new Tumbleweed.Scalar.Of.Value<String>(path)
	)
	{
	}
	
	public ResourceOnPath(Any<String> path) : base
	(
		new Tumbleweed.Scalar.Function.Result<T>(
			() => ResourceLoader.Load<T>(path.Value))
	)
	{
	}
}