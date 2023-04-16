using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

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
		INullaryFunction<IStorageElement<T>> function
	) : base
	(
		new ElementOfScalar<T>(
			new ValueOfFunction<IStorageElement<T>>(
				function))
	)
	{
	}
}