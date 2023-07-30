using Immutable = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Scalar.Immutable.From.Enumerable;

public sealed class First<T> : Immutable::Envelope<T>
{
	public First(SCG::IEnumerable<T> enumerable) : base
	(
		new Immutable::Function.Result.Actual<T>(
			enumerable.First)
	)
	{
	}
}