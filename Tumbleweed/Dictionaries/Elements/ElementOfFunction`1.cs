using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Dictionaries.Elements;

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