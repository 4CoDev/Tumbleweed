using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Nullability;
using Tumbleweed.Scalars;

namespace Tumbleweed.Elements;

public sealed class ElementOfFunction<T> : ElementEnvelope<T>
{
	public ElementOfFunction
	(
		Func<IElement<T>> function
	) : this
	(
		new NullaryFromSystem<IElement<T>>(function)
	)
	{
	}
	
	public ElementOfFunction
	(
		INullaryFunction<IElement<T>> function
	) : base
	(
		new ElementOfScalar<T>(
			new ValueOfFunction<IElement<T>>(
				function))
	)
	{
	}
}