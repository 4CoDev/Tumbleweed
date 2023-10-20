using Immutable = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;
using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Scalar.Immutable.From.Enumerable;

public sealed class Single<T> : Immutable::Envelope<T>
{
	public Single
	(
		SCG::IEnumerable<T> enumerable
	) : base
	(
		new Immutable::From.Enumerable.At.Index.System<T>(
			new Enumerable::Requirement.Length.System<T>(
				enumerable,
				1),
			0)
	)
	{
	}
}