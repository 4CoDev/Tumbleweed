using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Resource.FromFiles.ToGodot;

public sealed class ResourceOnPath<T> : Envelope<T> where T : class
{
	public ResourceOnPath(String path) : this
	(
		new Value<String>(path)
	)
	{
	}
	
	public ResourceOnPath(Any<String> path) : base
	(
		new Actual<T>(
			() => ResourceLoader.Load<T>(path.Value))
	)
	{
	}
}