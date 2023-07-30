using Nullable = Tumbleweed.Scalar.Nullable;
using System = System;
using Boolean = Tumbleweed.Boolean;

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

	public Boolean::Any HasValue =>
		nullable.HasValue;
	
	private readonly Nullable::Any<T> nullable;
}