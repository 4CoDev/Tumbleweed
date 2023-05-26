using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Function.Nullary;

namespace Tumbleweed.Storage.Element;

public sealed class ElementOfFunction<T> :
	ElementEnvelope<T>
	where T : notnull
{
	public ElementOfFunction
	(
		Func<IStorageElement<T>> function
	) : this
	(
		new FunctionFromSystem<IStorageElement<T>>(function)
	)
	{
	}
	
	public ElementOfFunction
	(
		IFunction<IStorageElement<T>> function
	) : base
	(
		new ElementOfScalar<T>(
			new ResultOfFunction<IStorageElement<T>>(
				function))
	)
	{
	}
}