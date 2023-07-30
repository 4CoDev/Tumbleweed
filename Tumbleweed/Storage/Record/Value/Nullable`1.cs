using Tumbleweed.Scalar.Nullable.Function;

namespace Tumbleweed.Storage.Record.Value;

public sealed class Nullable<T> : Scalar.Nullable.Envelope<T>
	where T : notnull
{
	public Nullable(Any<T> element) : base
	(
		new Result<T>(
			() => element.Value)
	)
	{
	}
}