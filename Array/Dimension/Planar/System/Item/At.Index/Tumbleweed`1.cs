using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Tumbleweed.Mathematics.Number.Natural;
using Property = Tumbleweed.Property;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using SystemInteger = Tumbleweed.Mathematics.Number.Integer.System.Medium;

namespace Tumbleweed.Array.Dimension.Planar.System.Item.At.Index;

public sealed class Tumbleweed<T> : Property::Transput.Envelope<T>
{
	public Tumbleweed
	(
		Property::Output.Any<T[,]> array,
		SCG::IEnumerable<Any> indices
	) : base
	(
		new System<T>(
			array,
			new Multiple(indices))
	)
	{
	}
}