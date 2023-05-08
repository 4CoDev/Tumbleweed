using Tumbleweed.Delegates.Functions.Nullary;
using Tumbleweed.Scalars;

namespace Tumbleweed.Lists;

public sealed class ListOfFunction<T> : ListEnvelope<T>
{
	public ListOfFunction
	(
		IFunction<IList<T>> function
	) : base
	(
		new ListOfScalar<T>(
			new ResultOfFunction<IList<T>>(function))
	)
	{
	}
}