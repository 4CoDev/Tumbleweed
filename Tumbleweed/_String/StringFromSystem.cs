using Tumbleweed.Scalar;

namespace Tumbleweed._String;

public sealed class StringFromSystem : IString
{
	public StringFromSystem(String @string) : this
	(
		new ScalarValue<String>(@string)
	)
	{
	}
	
	public StringFromSystem(IScalar<String> @string) =>
		this.@string = @string;
	
	public String Value =>
		@string.Value;
	
	private readonly IScalar<String> @string;
}