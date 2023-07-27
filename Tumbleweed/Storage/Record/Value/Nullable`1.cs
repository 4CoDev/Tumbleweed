namespace Tumbleweed.Storage.Record.Value;

public sealed class Nullable<T> : Nullable.Envelope<T>
	where T : notnull
{
	public Nullable(Any<T> element) : base
	(
		new Nullable.Result.Of.Function<T>(
			() => element.Value)
	)
	{
	}
}