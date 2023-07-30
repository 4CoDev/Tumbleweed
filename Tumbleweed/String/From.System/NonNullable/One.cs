using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.Of;
using Tumbleweed.Scalar.Immutable.With;

namespace Tumbleweed.String.From.System.NonNullable;

public sealed class One : Any
{
	public One(global::System.String @string) : this
	(
		new Value<global::System.String>(@string)
	)
	{
	}
	
	public One(Any<global::System.String> @string) =>
		this.@string = @string;
	
	public global::System.String Value =>
		@string.Value;
	
	private readonly Any<global::System.String> @string;
}