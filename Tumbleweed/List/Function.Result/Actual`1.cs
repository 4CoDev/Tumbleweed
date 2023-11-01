using Tumbleweed.List.Property.Value;
using Tumbleweed.Property.Output.Function.Result;

namespace Tumbleweed.List.Function.Result;

public sealed class Actual<T> : Envelope<T>
{
	public Actual
	(
		Subroutine.Function.Nullary.Any<IList<T>> function
	) : base
	(
		new Property.Value.Actual<T>(
			new global::Tumbleweed.Property.Output.Function.Result.Actual<IList<T>>
    (function))
	)
	{
	}
}