namespace Tumbleweed.List;

public sealed class ListOfFunction<T> : ListEnvelope<T>
{
	public ListOfFunction
	(Subroutine.Function.Nullary.Any<IList<T>> function
	) : base
	(
		new ListOfScalar<T>(
			new Scalar.Function.Result<IList<T>>(function))
	)
	{
	}
}