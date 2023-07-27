using Tumbleweed.Array.Scalar;

namespace Tumbleweed.Array.Storage.Record.Value;

public sealed class NonNullable<T> : Array.Envelope<T> where T : notnull
{
	public NonNullable
	(
		Tumbleweed.Storage.Record.Any<Array.Any<T>> record
	) : base
	(
		new Value<T>(
			new Tumbleweed.Storage.Record.Value.NonNullable<Array.Any<T>>(record))
	)
	{
	}
}