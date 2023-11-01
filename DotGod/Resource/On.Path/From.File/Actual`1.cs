using Godot;
using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.With;

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
		new Tumbleweed.Property.Output.Function.Result.Actual<T>(
			() => ResourceLoader.Load<T>(path.Value))
	)
	{
	}
}