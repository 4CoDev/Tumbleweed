using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;

namespace DotGod.Node.Generic.From.File.On.Path;

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