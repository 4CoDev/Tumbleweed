using Immutable = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Scalar.Immutable.From.Enumerable;

public sealed class Last<T> : Immutable::Envelope<T>
{
	public Last(SCG::IEnumerable<T> enumerable) : base
	(
		new Immutable::Function.Result.Actual<T>(
			enumerable.Last)
	)
	{
	}
}