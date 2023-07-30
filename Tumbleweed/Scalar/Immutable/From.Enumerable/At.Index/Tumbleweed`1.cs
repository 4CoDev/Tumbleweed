using Immutable = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Number.Natural;
using SystemInteger = Tumbleweed.Number.Integer.System.Medium;

namespace Tumbleweed.Scalar.Immutable.From.Enumerable.At.Index;

public sealed class Tumbleweed<T> : Immutable::Envelope<T>
{
	public Tumbleweed
	(
		SCG::IEnumerable<T> enumerable,
		Natural::Any index
	) : base
	(
		new Immutable::From.Enumerable.At.Index.System<T>(
			enumerable,
			new SystemInteger::From.Natural.Tumbleweed.One(index))
	)
	{
	}
}