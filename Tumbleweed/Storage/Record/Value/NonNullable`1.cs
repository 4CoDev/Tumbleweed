using Tumbleweed.Scalar.Nullable;

namespace Tumbleweed.Storage.Record.Value;

public sealed class NonNullable<T> : Scalar.Immutable.Envelope<T> where T : notnull
{
	public NonNullable(Record.Any<T> record) : base
	(
		new Record.Value.Nullable<T>(record)
	)
	{
	}
}