using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Property = Tumbleweed.Property;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using SystemInteger = Tumbleweed.Mathematics.Number.Integer.System.Medium;

namespace Tumbleweed.Array.Dimension.Spatial.System.Item.At.Index;

public sealed class Tumbleweed<T> : Property::Transput.Envelope<T>
{
	public Tumbleweed
	(
		Property::Output.Any<T[,,]> array,
		SCG::IEnumerable<Natural::Any> indices
	) : base
	(
		new System<T>(
			array,
			new Multiple(indices))
	)
	{
	}
}