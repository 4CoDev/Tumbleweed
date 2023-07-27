using Tumbleweed.Scalar.Function;
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
			new Tumbleweed.Scalar.Function.Result<IDictionaryElement<T>>(
				function))
	)
	{
	}
}