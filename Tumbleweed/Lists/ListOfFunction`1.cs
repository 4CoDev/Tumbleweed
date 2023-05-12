using Tumbleweed.Scalars;
using Tumbleweed.Subroutines.Functions.Nullary;

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