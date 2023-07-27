using Mutable = Tumbleweed.Mutable;
using Scalar = Tumbleweed.Scalar;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Number.Natural;
using SystemInteger = Tumbleweed.Number.Integer.System.Medium;

namespace Tumbleweed.Array.Dimension.Planar.System.Item.At.Index;

public sealed class Tumbleweed<T> : Mutable::Envelope<T>
{
	public Tumbleweed
	(
		Scalar::Any<T[,]> array,
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