using Enumerable = Tumbleweed.Enumerable;
using Scalar = Tumbleweed.Scalar;
using SCG = System.Collections.Generic;

namespace Tumbleweed.Enumerable.Lazy;

public sealed class New<T> : Enumerable::Envelope<T>
{
	public New(IEnumerable<T> enumerable) : base
	(
		new Enumerable::Scalar.Value<T>(
			new Scalar::Lazy.Result.Of.Function<IEnumerable<T>>(
				() => new SCG::List<T>(enumerable)))
	)
	{
	}
}