using Tumbleweed.Mathematics.Number.Natural;
using Tumbleweed.Mathematics.Number.Natural.From.System;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With;
using Enumerable = Tumbleweed.Enumerable;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using Property = Tumbleweed.Property;

namespace Tumbleweed.Array.Dimension.Spatial.System.Size;

public sealed class Tumbleweed<T> : Enumerable::Envelope<Any>
{
	public Tumbleweed(T[,,] array) : this
	(
		new Value<T[,,]>(array)
	)
	{
	}
	
	public Tumbleweed(Tumbleweed.Property.Output.Any<T[,,]> array) : base
	(
		new Multiple(
			new System<T>(array))
	)
	{
	}
}