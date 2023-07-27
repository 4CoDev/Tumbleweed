using System.Collections;
using System = System;

namespace Tumbleweed.Enumerable;

public abstract class Envelope<T> : IEnumerable<T>
{
	protected Envelope(IEnumerable<T> enumerable) =>
		this.enumerable = enumerable;
	
	IEnumerator IEnumerable.GetEnumerator() =>
		GetEnumerator();
	
	public IEnumerator<T> GetEnumerator() =>
		enumerable.GetEnumerator();

	public override System::Boolean Equals(System::Object? @object) =>
		enumerable.Equals(@object);

	public override System::Int32 GetHashCode() =>
		enumerable.GetHashCode();

	public override System::String? ToString() =>
		enumerable.ToString();

	private readonly IEnumerable<T> enumerable;
}