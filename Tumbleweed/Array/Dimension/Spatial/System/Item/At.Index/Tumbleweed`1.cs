using Mutable = Tumbleweed.Scalar.Mutable;
using Immutable = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Number.Natural;
using SystemInteger = Tumbleweed.Number.Integer.System.Medium;

namespace Tumbleweed.Array.Dimension.Spatial.System.Item.At.Index;

public sealed class Tumbleweed<T> : Mutable::Envelope<T>
{
	public Tumbleweed
	(
		Immutable::Any<T[,,]> array,
		SCG::IEnumerable<Natural::Any> indices
	) : base
	(
		new System<T>(
			array,
			new SystemInteger::From.Natural.Tumbleweed.Multiple(indices))
	)
	{
	}
}