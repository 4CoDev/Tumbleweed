using System = System;

namespace Tumbleweed.String;

public abstract class Envelope : Any
{
	protected Envelope(Any @string) =>
		this.@string = @string;

	public override System::Boolean Equals(System::Object? @object) =>
		@string.Equals(@object);

	public override Int32 GetHashCode() =>
		@string.GetHashCode();

	public override global::System.String? ToString() =>
		@string.ToString();

	public global::System.String Value =>
		@string.Value;
	
	private readonly Any @string;
}