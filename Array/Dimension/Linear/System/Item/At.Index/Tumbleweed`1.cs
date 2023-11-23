using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Tumbleweed.Mathematics.Number.Natural;
using Property = Tumbleweed.Property;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using Single = Tumbleweed.Mathematics.Number.Natural.From.Enumerable.Single;
using SystemInteger = Tumbleweed.Mathematics.Number.Integer.System.Medium;

namespace Tumbleweed.Array.Dimension.Linear.System.Item.At.Index;

public sealed class Tumbleweed<T> : Property::Transput.Envelope<T>
{
	public Tumbleweed
	(
		Property::Output.Any<T[]> array,
		SCG::IEnumerable<Any> indices
	) : this
	(
		array,
		new Single(indices)
	)
	{
	}
	
	public Tumbleweed
	(
		Property::Output.Any<T[]> array,
		Any index
	) : base
	(
		new System<T>(
			array,
			new One(index))
	)
	{
	}
}