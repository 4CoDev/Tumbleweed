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
		INullaryFunction<IDictionaryElement<T>> function
	) : base
	(
		new ElementOfScalar<T>(
			new ValueOfFunction<IDictionaryElement<T>>(
				function))
	)
	{
	}
}