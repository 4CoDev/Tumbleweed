using Tumbleweed.Mathematics.Number.Integer.System.Medium.From.Natural.Tumbleweed;
using Tumbleweed.Mathematics.Number.Natural;
using Immutable = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;
using Natural = Tumbleweed.Mathematics.Number.Natural;
using SystemInteger = Tumbleweed.Mathematics.Number.Integer.System.Medium;

namespace Tumbleweed.Scalar.Immutable.From.Enumerable.At.Index;

public sealed class Tumbleweed<T> : Immutable::Envelope<T>
{
	public Tumbleweed
	(
		SCG::IEnumerable<T> enumerable,
		Any index
	) : base
	(
		new Immutable::From.Enumerable.At.Index.System<T>(
			enumerable,
			new One(index))
	)
	{
	}
}