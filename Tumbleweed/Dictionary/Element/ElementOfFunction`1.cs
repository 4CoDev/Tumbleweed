using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Subroutine.Function.Nullary;
using Tumbleweed.Subroutine.Function.Nullary.From;

namespace Tumbleweed.Dictionary.Element;

public sealed class ElementOfFunction<T> :
	ElementEnvelope<T>
	where T : notnull
{
	public ElementOfFunction
	(
		Func<IDictionaryElement<T>> function
	) : this
	(
		new System<IDictionaryElement<T>>(function)
	)
	{
	}
	
	public ElementOfFunction
	(Subroutine.Function.Nullary.Any<IDictionaryElement<T>> function
	) : base
	(
		new ElementOfScalar<T>(
			new Actual<IDictionaryElement<T>>(
				function))
	)
	{
	}
}