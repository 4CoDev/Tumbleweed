using Scalar = Tumbleweed.Scalar.Immutable;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Array.Dimension.Linear.System.From.Enumerable;

public sealed class One<T> : Scalar::Envelope<T[]>
{
	public One(SCG::IEnumerable<T> enumerable) : base
	(
		new Scalar::Function.Result.Actual<T[]>(
			enumerable.ToArray)
	)
	{
	}
}