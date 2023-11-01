namespace Tumbleweed.Collection.Function.Result;

public sealed class Actual<T> : Envelope<T>
{
	public Actual(Func<ICollection<T>> @delegate) : base
	(
		new Property.Value.Actual<T>(
			new Tumbleweed.Property.Output.Function.Result.Actual<ICollection<T>>(@delegate))
	)
	{
	}
}