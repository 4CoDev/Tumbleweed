using Tumbleweed.Scalar;
using Tumbleweed.Subroutine.Nullary.Function;

namespace Tumbleweed._List;

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