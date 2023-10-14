using Tumbleweed.Mathematics.Boolean;
using Nullable = Tumbleweed.Scalar.Nullable;
using System = System;


namespace Tumbleweed.Scalar.Nullable;

public abstract class Envelope<T> : Nullable::Any<T>
{
	protected Envelope(Nullable::Any<T> nullable) =>
		this.nullable = nullable;

	public override System::Boolean Equals
	(
		System::Object? @object
	) =>
	(
		nullable.Equals(@object)
	);

	public override System::Int32 GetHashCode() =>
		nullable.GetHashCode();

	public override System::String? ToString() =>
		nullable.ToString();

	public T Value =>
		nullable.Value;

	public Any HasValue =>
		nullable.HasValue;
	
	private readonly Nullable::Any<T> nullable;
}