namespace Tumbleweed.Collection.Function.Result;

public sealed class Actual<T> : Envelope<T>
{
	public Actual(Func<ICollection<T>> @delegate) : base
	(
		new Scalar.Value.Actual<T>(
			new Tumbleweed.Scalar.Immutable.Function.Result.Actual<ICollection<T>>(@delegate))
	)
	{
	}
}