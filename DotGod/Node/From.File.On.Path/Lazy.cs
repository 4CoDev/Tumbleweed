using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.From.File.On.Path;

public sealed class Lazy : Envelope<Godot.Node> 
{
	public Lazy(String path) : this
	(
		new Value<String>(path)
	)
	{
	}
	
	public Lazy(Any<String> path) : base
	(
		new Lazy<Godot.Node>(path)
	)
	{
	}
}