using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;

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
		new Tumbleweed.Property.Output.Lazy<T>(
			new Actual<T>(path))
	)
	{
	}
}