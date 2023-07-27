using ReadOnlySpan = Tumbleweed.Memory.Span.ReadOnly;

namespace Tumbleweed.Memory.Span.ReadOnly.System.Function;

public sealed class Result<T> : ReadOnlySpan.Any<T>
{
	public Result(Definition<T> function) : this
	(
		new Scalar.Of.Value<Definition<T>>(function)
	)
	{
	}
	
	public Result(Scalar.Any<Definition<T>> function) =>
		this.function = function;

	public global::System.ReadOnlySpan<T> Value =>
		function.Value();

	private readonly Scalar.Any<Definition<T>> function;
}