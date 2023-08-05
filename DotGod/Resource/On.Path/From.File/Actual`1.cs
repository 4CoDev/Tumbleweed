using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Resource.On.Path.From.File;

public sealed class Actual<T> : Envelope<T> where T : class
{
	public Actual(String path) : this
	(
		new Value<String>(path)
	)
	{
	}
	
	public Actual(Any<String> path) : base
	(
		new Tumbleweed.Scalar.Immutable.Function.Result.Actual<T>(
			() => ResourceLoader.Load<T>(path.Value))
	)
	{
	}
}