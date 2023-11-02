using Godot;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With.Value;

namespace DotGod.Node.Generic.From.File.On.Path;

public sealed class Actual<T> : Envelope<T> where T : Godot.Node
{
	public Actual(String path) : this
	(
		new One<String>(path)
	)
	{
	}
	
	public Actual(Any<String> path) : base
	(
		new Tumbleweed.Property.Output.Function.Result.Actual<T>(
			() => new Resource.On.Path.From.File.Actual<PackedScene>(path).Value.Instantiate<T>())
	)
	{
	}
}