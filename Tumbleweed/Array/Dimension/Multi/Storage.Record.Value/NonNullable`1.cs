using Tumbleweed.Array.Dimension.Multi.Scalar.Value.Actual;

namespace Tumbleweed.Array.Dimension.Multi.Storage.Record.Value;

public sealed class NonNullable<T> : Envelope<T> where T : notnull
{
	public NonNullable
	(
		Tumbleweed.Storage.Record.Any<Any<T>> record
	) : base
	(
		new Actual<T>(
			new Tumbleweed.Storage.Record.Value.NonNullable<Any<T>>(record))
	)
	{
	}
}