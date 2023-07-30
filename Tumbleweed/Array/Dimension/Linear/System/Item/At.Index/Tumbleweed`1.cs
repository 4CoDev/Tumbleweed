using Mutable = Tumbleweed.Scalar.Mutable;
using Immutable = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Number.Natural;
using SystemInteger = Tumbleweed.Number.Integer.System.Medium;

namespace Tumbleweed.Array.Dimension.Linear.System.Item.At.Index;

public sealed class Tumbleweed<T> : Mutable::Envelope<T>
{
	public Tumbleweed
	(
		Immutable::Any<T[]> array,
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
		Immutable::Any<T[]> array,
		Natural::Any index
	) : base
	(
		new System<T>(
			array,
			new SystemInteger::From.Natural.Tumbleweed.One(index))
	)
	{
	}
}