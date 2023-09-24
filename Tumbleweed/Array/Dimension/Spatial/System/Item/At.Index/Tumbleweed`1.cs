using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Tumbleweed.Mathematics.Number.Natural;
using Mutable = Tumbleweed.Scalar.Mutable;
using Immutable = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using SystemInteger = Tumbleweed.Mathematics.Number.Integer.System.Medium;

namespace Tumbleweed.Array.Dimension.Spatial.System.Item.At.Index;

public sealed class Tumbleweed<T> : Mutable::Envelope<T>
{
	public Tumbleweed
	(
		Immutable::Any<T[,,]> array,
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