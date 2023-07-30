using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;
using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

namespace Tumbleweed.Memory.Span.ReadOnly.System.Function;

public sealed class Result<T> : ReadOnlySpan.Any<T>
{
	public Result(Definition<T> function) : this
	(
		new Value<Definition<T>>(function)
	)
	{
	}
	
	public Result(Scalar.Immutable.Any<Definition<T>> function) =>
		this.function = function;

	public global::System.ReadOnlySpan<T> Value =>
		function.Value();

	private readonly Scalar.Immutable.Any<Definition<T>> function;
}