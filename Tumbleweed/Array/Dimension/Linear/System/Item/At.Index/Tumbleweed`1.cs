using Mutable = Tumbleweed.Mutable;
using Scalar = Tumbleweed.Scalar;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Number.Natural;
using Integer = Tumbleweed.Number.Integer;

namespace Tumbleweed.Array.Dimension.Linear.System.Item.At.Index;

public sealed class Tumbleweed<T> : Mutable::Envelope<T>
{
	public Tumbleweed
	(
		Scalar::Any<T[]> array,
		SCG::IEnumerable<Natural::Any> indices
	) : this
	(
		array,
		new Natural::From.Enumerable.Single(indices)
	)
	{
	}
	
	public Tumbleweed
	(
		Scalar::Any<T[]> array,
		Natural::Any index
	) : base
	(
		new System<T>(
			array,
			new Integer::System.Medium.From.Natural.Tumbleweed.One(index))
	)
	{
	}
}