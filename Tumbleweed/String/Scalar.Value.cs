using System = System;

namespace Tumbleweed.String;

public sealed class ScalarValue : Any
{
	public ScalarValue(Scalar.Any<Any> scalar) =>
		this.scalar = scalar;

	public override System::Boolean Equals(System::Object? @object) =>
		Value.Equals(@object);

	public override Int32 GetHashCode() =>
		Value.GetHashCode();

	public override global::System.String ToString() =>
		Value;

	public global::System.String Value =>
		scalar.Value.Value;
	
	private readonly Scalar.Any<Any> scalar;
}