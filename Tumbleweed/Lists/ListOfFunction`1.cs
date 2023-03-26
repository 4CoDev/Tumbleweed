using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Lists;

public sealed class ListOfFunction<T> : ListEnvelope<T>
{
	public ListOfFunction
	(
		INullaryFunction<IList<T>> function
	) : base
	(
		new ListOfScalar<T>(
			new ValueOfFunction<IList<T>>(function))
	)
	{
	}
}