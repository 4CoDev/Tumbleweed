namespace Tumbleweed._String;

public abstract class StringEnvelope : IString
{
	protected StringEnvelope(IString @string) =>
		this.@string = @string;

	public override Boolean Equals(Object? @object) =>
		@string.Equals(@object);

	public override Int32 GetHashCode() =>
		@string.GetHashCode();

	public override String? ToString() =>
		@string.ToString();

	public String Value =>
		@string.Value;
	
	private readonly IString @string;
}