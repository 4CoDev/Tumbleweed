using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With;
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
	
	public Result(Property.Output.Any<Definition<T>> function) =>
		this.function = function;

	public global::System.ReadOnlySpan<T> Value =>
		function.Value();

	private readonly Property.Output.Any<Definition<T>> function;
}