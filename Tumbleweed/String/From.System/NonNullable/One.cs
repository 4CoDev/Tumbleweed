namespace Tumbleweed.String.From.System.NonNullable;

public sealed class One : Any
{
	public One(global::System.String @string) : this
	(
		new Tumbleweed.Scalar.Of.Value<global::System.String>(@string)
	)
	{
	}
	
	public One(Scalar.Any<global::System.String> @string) =>
		this.@string = @string;
	
	public global::System.String Value =>
		@string.Value;
	
	private readonly Scalar.Any<global::System.String> @string;
}