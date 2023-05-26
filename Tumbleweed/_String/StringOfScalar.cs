using Tumbleweed.Scalar;

namespace Tumbleweed._String;

public sealed class StringOfScalar : IString
{
	public StringOfScalar(IScalar<IString> scalar) =>
		this.scalar = scalar;

	public override Boolean Equals(Object? @object) =>
		Value.Equals(@object);

	public override Int32 GetHashCode() =>
		Value.GetHashCode();

	public override String ToString() =>
		Value;

	public String Value =>
		scalar.Value.Value;
	
	private readonly IScalar<IString> scalar;
}