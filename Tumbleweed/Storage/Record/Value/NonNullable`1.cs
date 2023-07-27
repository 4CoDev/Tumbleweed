using Tumbleweed.Nullable;

namespace Tumbleweed.Storage.Record.Value;

public sealed class NonNullable<T> : Scalar.Envelope<T> where T : notnull
{
	public NonNullable(Record.Any<T> record) : base
	(
		new Value<T>(
			new Record.Value.Nullable<T>(record))
	)
	{
	}
}