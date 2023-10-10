using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.Generic.From.File.On.Path;

public sealed class Snapshot<T> : Envelope<T> where T : Godot.Node
{
	public Snapshot(String path) : this
	(
		new Value<String>(path)
	)
	{
	}
	
	public Snapshot(Any<String> path) : base
	(
		new Tumbleweed.Scalar.Immutable.Lazy<T>(
			new Actual<T>(path))
	)
	{
	}
}