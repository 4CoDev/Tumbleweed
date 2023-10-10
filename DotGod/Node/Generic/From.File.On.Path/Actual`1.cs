using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Generic.From.File.On.Path;

public sealed class Actual<T> : Envelope<T> where T : Godot.Node
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
			() => new Resource.On.Path.From.File.Actual<PackedScene>(path).Value.Instantiate<T>())
	)
	{
	}
}