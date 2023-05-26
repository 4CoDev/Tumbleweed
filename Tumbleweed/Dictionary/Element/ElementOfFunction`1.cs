using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Function.Nullary;

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
		new FunctionFromSystem<IDictionaryElement<T>>(function)
	)
	{
	}
	
	public ElementOfFunction
	(
		IFunction<IDictionaryElement<T>> function
	) : base
	(
		new ElementOfScalar<T>(
			new ResultOfFunction<IDictionaryElement<T>>(
				function))
	)
	{
	}
}