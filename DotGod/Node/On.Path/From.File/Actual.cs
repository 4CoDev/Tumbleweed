using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.With;

namespace DotGod.Node.On.Path.From.File;

public sealed class Actual : Envelope<Godot.Node> 
{
	public Actual(String path) : this
	(
		new Value<String>(path)
	)
	{
	}
	
	public Actual(Any<String> path) : base
	(
		new Actual<Godot.Node>(path)
	)
	{
	}
}