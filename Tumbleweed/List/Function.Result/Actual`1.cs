using Tumbleweed.List.Scalar.Value;
using Tumbleweed.Scalar.Immutable.Function.Result;

namespace Tumbleweed.List.Function.Result;

public sealed class Actual<T> : Envelope<T>
{
	public Actual
	(
		Subroutine.Function.Nullary.Any<IList<T>> function
	) : base
	(
		new Scalar.Value.Actual<T>(
			new global::Tumbleweed.Scalar.Immutable.Function.Result.Actual<IList<T>>
    (function))
	)
	{
	}
}