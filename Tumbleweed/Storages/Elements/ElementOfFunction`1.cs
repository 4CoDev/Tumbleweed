using Tumbleweed.Scalars;
using Tumbleweed.Subroutines.Functions.Nullary;

namespace Tumbleweed.Storages.Elements;

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