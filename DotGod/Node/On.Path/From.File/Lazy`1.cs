using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.On.Path.From.File;

public sealed class Lazy<T> : Envelope<T> where T : Godot.Node
{
	public Lazy(String path) : this
	(
		new Value<String>(path)
	)
	{
	}
	
	public Lazy(Any<String> path) : base
	(
		new Tumbleweed.Scalar.Immutable.Lazy<T>(
			new Actual<T>(path))
	)
	{
	}
}