using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.Of;
using Tumbleweed.Property.Output.With.Value;

namespace Tumbleweed.String.From.System.NonNullable;

public sealed class One : Any
{
	public One(global::System.String @string) : this
	(
		new One<global::System.String>(@string)
	)
	{
	}
	
	public One(Any<global::System.String> @string) =>
		this.@string = @string;
	
	public global::System.String AsSystem =>
		@string.Value;
	
	private readonly Any<global::System.String> @string;
}